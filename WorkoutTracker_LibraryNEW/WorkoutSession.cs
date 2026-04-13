using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // lasten delegat — lastna signatura za dogodke treninga
    public delegate void WorkoutEventHandler(WorkoutSession session, string message);
    // drugi lasten delegat — specificen za opozorila o preobremenitvi
    public delegate void PreobremenitevHandler(SetEntry set, string opozorilo);

    // WorkoutSession implementira vmesnik IHasVolume
    public class WorkoutSession : IHasVolume
    {
        public DateTime StartTime { get; private set; }
        public bool IsRunning { get; private set; }
        public bool IsPaused { get; private set; }
        // dogodek za opozorilo o preobremenitvi — sprozi se ko je RPE >= 9
        // GUI se naroči na ta event in prikaže opozorilo uporabniku
        public event PreobremenitevHandler OnPreobremenitev;
        // kapsulacija — privatna lista, navzven samo IReadOnlyList (brez moznosti dodajanja mimo AddSet)
        private List<SetEntry> _sets = new List<SetEntry>();
        public IReadOnlyList<SetEntry> Sets => _sets.AsReadOnly();

        // dogodki (events) — uporaba lastnega delegata WorkoutEventHandler
        public event WorkoutEventHandler OnSetAdded;
        public event WorkoutEventHandler OnWorkoutStarted;
        public event WorkoutEventHandler OnWorkoutEnded;
        public event WorkoutEventHandler OnWorkoutPaused;
        public event WorkoutEventHandler OnWorkoutResumed;
        private DateTime _start;
        private TimeSpan _pausedTotal = TimeSpan.Zero;
        private DateTime _pauseStart;

        // indekser — dostop do setov kot session[0], session[1] ...
        public SetEntry this[int i]
        {
            get { return _sets[i]; }
        }
        // indekser po imenu vaje (string) — smiseln ker iscemo sete po imenu vaje, ne samo po poziciji
        // npr. session["Bench Press"] vrne prvi set za to vajo
        public SetEntry this[string exerciseName]
        {
            get
            {
                for (int i = 0; i < _sets.Count; i++)
                {
                    if (_sets[i].ExerciseName == exerciseName)
                        return _sets[i];
                }
                throw new KeyNotFoundException($"Set za vajo '{exerciseName}' ne obstaja v tej seji.");
            }
        }

        // implementacija vmesnika IHasVolume
        public TrainingVolume GetVolume()
        {
            return TotalVolume;
        }

        // lastnost z logiko v getterju — izracun trajanja treninga
        public string DurationText
        {
            get
            {
                if (!IsRunning) return "00:00:00";
                TimeSpan t = DateTime.Now - _start - _pausedTotal;
                if (IsPaused) t = _pauseStart - _start - _pausedTotal;
                return t.ToString(@"hh\:mm\:ss");
            }
        }

        // lastnost z logiko v getterju — izracun celotnega volumna
        public TrainingVolume TotalVolume
        {
            get
            {
                TrainingVolume sum = new TrainingVolume(0);
                for (int i = 0; i < _sets.Count; i++)
                {
                    double v = _sets[i].Kg * _sets[i].Reps;
                    sum = sum + new TrainingVolume(v);
                }
                return sum;
            }
        }

        public void AddSet(SetEntry set)
        {
            _sets.Add(set);
            OnSetAdded?.Invoke(this, "Dodan set: " + set.ExerciseName + " " + set.Kg + "kg x " + set.Reps);

            // preverimo ali je RPE kritičen (9 ali 10) — opozorilo za preobremenitev
            if (set.RPE >= 9)
            {
                OnPreobremenitev?.Invoke(set,
                    "OPOZORILO: Visok RPE (" + set.RPE + ") pri vaji " + set.ExerciseName +
                    "! Priporočam daljši odmor ali zmanjšanje teže.");
            }
        }
        public void Start()
        {
            StartTime = DateTime.Now;
            _start = DateTime.Now;
            _pausedTotal = TimeSpan.Zero;
            IsPaused = false;
            IsRunning = true;
            OnWorkoutStarted?.Invoke(this, "Trening se je začel.");
        }

        public void Pause()
        {
            if (!IsRunning || IsPaused) return;
            IsPaused = true;
            _pauseStart = DateTime.Now;
            OnWorkoutPaused?.Invoke(this, "Trening pauziran.");
        }

        public void Resume()
        {
            if (!IsRunning || !IsPaused) return;
            IsPaused = false;
            _pausedTotal += (DateTime.Now - _pauseStart);
            OnWorkoutResumed?.Invoke(this, "Trening nadaljevan.");
        }

        public void End()
        {
            IsRunning = false;
            IsPaused = false;
            OnWorkoutEnded?.Invoke(this, "Trening končan. Volumen: " + TotalVolume.ToString());
        }
    }
}
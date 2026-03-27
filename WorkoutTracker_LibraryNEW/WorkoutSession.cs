using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // Lasten delegat (Faza 3)
    public delegate void WorkoutEventHandler(WorkoutSession session, string message);
    public class WorkoutSession : IHasVolume
    {
        public DateTime StartTime { get; private set; }
        public bool IsRunning { get; private set; }
        public bool IsPaused { get; private set; }

        public List<SetEntry> Sets { get; private set; } = new List<SetEntry>();

        public event WorkoutEventHandler OnSetAdded;
        public event WorkoutEventHandler OnWorkoutStarted;
        public event WorkoutEventHandler OnWorkoutEnded;
        public event WorkoutEventHandler OnWorkoutPaused;
        public event WorkoutEventHandler OnWorkoutResumed;
        private DateTime _start;
        private TimeSpan _pausedTotal = TimeSpan.Zero;
        private DateTime _pauseStart;

        public SetEntry this[int i]
        {
            get { return Sets[i]; }
        }

        public TrainingVolume GetVolume()
        {
            return TotalVolume;
        }

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

        public TrainingVolume TotalVolume
        {
            get
            {
                TrainingVolume sum = new TrainingVolume(0);
                for (int i = 0; i < Sets.Count; i++)
                {
                    double v = Sets[i].Kg * Sets[i].Reps;
                    sum = sum + new TrainingVolume(v);
                }
                return sum;
            }
        }

        public void AddSet(SetEntry set)
        {
            Sets.Add(set);
            OnSetAdded?.Invoke(this, "Dodan set: " + set.ExerciseName + " " + set.Kg + "kg x " + set.Reps);
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
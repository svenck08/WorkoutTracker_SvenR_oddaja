using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
 public class WorkoutSession
    {
        public DateTime StartTime { get; set; }
        public bool IsRunning { get; set; }
        public bool IsPaused { get; set; }

        public List<SetEntry> Sets { get; set; } = new List<SetEntry>();

        private DateTime _start;
        private TimeSpan _pausedTotal = TimeSpan.Zero;
        private DateTime _pauseStart;

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
        public void Start()
        {
            StartTime = DateTime.Now;
            _start = DateTime.Now;
            _pausedTotal = TimeSpan.Zero;
            IsPaused = false;
            IsRunning = true;
        }

        public void Pause()
        {
            if (!IsRunning || IsPaused) return;
            IsPaused = true;
            _pauseStart = DateTime.Now;
        }

        public void Resume()
        {
            if (!IsRunning || !IsPaused) return;
            IsPaused = false;
            _pausedTotal += (DateTime.Now - _pauseStart);
        }
        public void End()
        {
            IsRunning = false;
            IsPaused = false;
        }
    }
}

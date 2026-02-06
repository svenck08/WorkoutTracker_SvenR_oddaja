using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class TrainingVolume
    {
        public double Value { get; set; }
        public TrainingVolume(double value)
        {
            if (value < 0) value = 0;
            Value = value;
        }
        public static TrainingVolume operator +(TrainingVolume a, TrainingVolume b)
        {
            return new TrainingVolume(a.Value + b.Value);
        }
        public override string ToString()
        {
            return Value.ToString("0");
        }
    }
}

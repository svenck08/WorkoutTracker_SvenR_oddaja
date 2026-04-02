using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class TrainingVolume
    {
        // kapsulacija — private set prepreci nastavljanje od zunaj
        public double Value { get; private set; }
        public TrainingVolume(double value)
        {
            if (value < 0) value = 0;
            Value = value;
        }
        // preoblaganje operatorja +
        public static TrainingVolume operator +(TrainingVolume a, TrainingVolume b)
        {
            return new TrainingVolume(a.Value + b.Value); // vsakic se ustvari nov objekt tipa TrainingVolume
        }
        // preoblaganje primerjalnih operatorjev — smiselno za primerjavo volumnov
        public static bool operator >(TrainingVolume a, TrainingVolume b)
        {
            return a.Value > b.Value;
        }
        public static bool operator <(TrainingVolume a, TrainingVolume b)
        {
            return a.Value < b.Value;
        }
        // implicitna pretvorba iz double — omogoca npr. TrainingVolume v = 100.0;
        public static implicit operator TrainingVolume(double val)
        {
            return new TrainingVolume(val);
        }
        public override string ToString()
        {
            return Value.ToString("0");
        }
    }
}

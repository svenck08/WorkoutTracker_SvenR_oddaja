using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // dedovanje — StrengthExercise razsirja Exercise z lastno logiko (1RM)
    public class StrengthExercise : Exercise
    {
        // lastnost specificna za vaje za moc
        public double OneRepMax { get; private set; }

        // konstruktor klice base konstruktor (dedovanje)
        public StrengthExercise(string name, string device, List<string> muscles)
            : base(name, device, ExerciseType.Moc, muscles)
        {
            OneRepMax = 0;
        }

        // objektna metoda — Epley formula za oceno 1RM
        public void UpdateOneRepMax(double kg, int reps)
        {
            if (reps <= 0 || kg <= 0) return;
            double estimated = (reps == 1) ? kg : kg * (1 + reps / 30.0);
            if (estimated > OneRepMax)
                OneRepMax = estimated;
        }

        // override ToString — polimorfizem na nivoju Exercise
        public override string ToString()
        {
            string s = base.ToString();
            if (OneRepMax > 0)
                s += " [1RM: " + OneRepMax.ToString("0.0") + " kg]";
            return s;
        }
    }
}

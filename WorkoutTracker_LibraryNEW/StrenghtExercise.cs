using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class StrengthExercise : Exercise
    {
        public StrengthExercise(string name, string device, List<string> muscles)
            : base(name, device, ExerciseType.Moc, muscles)
        {
        }
    }
}

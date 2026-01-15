using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class SetEntry
    {
        public string ExerciseName { get; set; }
        public double Kg { get; set; }
        public int Reps { get; set; }
        public int RPE { get; set; }
        public DateTime Time { get; set; }

        public double VolumeValue
        {
            get { return Kg * Reps; }
        }
        public SetEntry(string exerciseName, double kg, int reps, int rpe)
        {
            if (exerciseName == null || exerciseName.Trim().Length == 0)
                throw new Exception("Vaja ni izbrana.");
            if (kg < 0) throw new Exception("Kg ne sme biti negativno.");
            if (reps <= 0) throw new Exception("Reps mora biti > 0.");
            if (rpe < 1 || rpe > 10) throw new Exception("RPE mora biti 1–10.");
            ExerciseName = exerciseName;
            Kg = kg;
            Reps = reps;
            RPE = rpe;
            Time = DateTime.Now;
        }
    }
}

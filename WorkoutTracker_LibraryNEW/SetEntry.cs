using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // vmesnik IHasVolume — implementirajo ga SetEntry IN WorkoutSession (dva razreda)
    public class SetEntry : IHasVolume
    {
        // kapsulacija — private set prepreci spreminjanje od zunaj
        public string ExerciseName { get; private set; }
        private double _kg;
        public double Kg
        {
            get { return _kg; }
            private set
            {
                if (value < 0) throw new Exception("Teža ne sme biti negativna.");
                _kg = value;
            }
        }
        public int Reps { get; private set; }
        private int _rpe;
        public int RPE
        {
            get { return _rpe; }
            private set
            {
                if (value < 1 || value > 10)
                    throw new Exception("RPE mora biti med 1 in 10.");
                _rpe = value;
            }
        }
        public DateTime Time { get; private set; }

        // lastnost z logiko v getterju — izracun volumna seta
        public double VolumeValue
        {
            get { return Kg * Reps; }
        }
        // implementacija vmesnika IHasVolume
        public TrainingVolume GetVolume()
        {
            return new TrainingVolume(Kg * Reps);
        }
        // konstruktor z validacijo — preverja pravilnost vhodnih podatkov
        public SetEntry(string exerciseName, double kg, int reps, int rpe)
        {
            if (exerciseName == null || exerciseName.Trim().Length == 0)
                throw new Exception("Vaja ni izbrana.");
            if (reps <= 0) throw new Exception("Reps mora biti > 0.");
            ExerciseName = exerciseName;
            Kg = kg;       // validacija se zgodi v setterju
            Reps = reps;
            RPE = rpe;     // validacija se zgodi v setterju
            Time = DateTime.Now;
        }
    }
}

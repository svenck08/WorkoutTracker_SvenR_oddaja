using System;
using System.Collections.Generic;

namespace WorkoutTracker_LibraryNEW
{
    // dedovanje — CardioExercise razsirja Exercise z lastno logiko (trajanje, razdalja)
    // to je DRUGA VEJA dedovanja poleg StrengthExercise
    public class CardioExercise : Exercise
    {
        // lastnosti specificne za kardio vaje
        private double _distanceKm;
        public double DistanceKm
        {
            get { return _distanceKm; }
            set
            {
                if (value < 0) throw new Exception("Razdalja ne sme biti negativna.");
                _distanceKm = value;
            }
        }

        private int _durationMinutes;
        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set
            {
                if (value < 0) throw new Exception("Trajanje ne sme biti negativno.");
                _durationMinutes = value;
            }
        }

        // izracunana lastnost — tempo (min/km)
        public double Tempo
        {
            get
            {
                if (DistanceKm <= 0) return 0;
                return Math.Round(DurationMinutes / DistanceKm, 2);
            }
        }

        // konstruktor klice base konstruktor
        public CardioExercise(string name, string device, List<string> muscles)
            : base(name, device, ExerciseType.Kardio, muscles)
        {
            DistanceKm = 0;
            DurationMinutes = 0;
        }

        // objektna metoda — posodobi kardio podatke po treningu
        public void UpdateCardioData(double distanceKm, int durationMinutes)
        {
            DistanceKm = distanceKm;
            DurationMinutes = durationMinutes;
        }
        // polimorfizem — CardioExercise izpise razdaljo in tempo, ki ju StrengthExercise nima
        public override string IzpisPodrobnosti()
        {
            string s = base.IzpisPodrobnosti();
            if (DistanceKm > 0)
                s += $"\n  Razdalja: {DistanceKm:0.0} km, Trajanje: {DurationMinutes} min, Tempo: {Tempo:0.0} min/km";
            else
                s += "\n  Kardio podatki: ni podatkov";
            return s;
        }
        // polimorfizem — override ToString() prikazuje drugacne podatke kot StrengthExercise
        public override string ToString()
        {
            string s = base.ToString();
            if (DistanceKm > 0)
                s += $" [Razdalja: {DistanceKm:0.0} km, Tempo: {Tempo:0.0} min/km]";
            return s;
        }
    }
}
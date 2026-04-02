using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class ExerciseType
    {
        // static readonly — fiksne instance tipov vaj (enum-like vzorec)
        public static readonly ExerciseType Moc = new ExerciseType("Moč", "Vaje za moč in mišično maso");
        public static readonly ExerciseType Kardio = new ExerciseType("Kardio", "Kardiovaskularne vaje");
        public static readonly ExerciseType Regeneracija = new ExerciseType("Regeneracija", "Vaje za regeneracijo in raztezanje");

        public static readonly List<ExerciseType> All = new List<ExerciseType> { Moc, Kardio, Regeneracija };

        // kapsulacija — lastnosti z private set
        public string Name { get; private set; }
        public string Description { get; private set; }

        // privatni konstruktor — prepreci ustvarjanje novih tipov od zunaj
        private ExerciseType(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
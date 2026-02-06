using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class Exercise
    {
        public const int MinNameLength = 2;
        private static int _nextId = 1;
        public readonly DateTime CreatedAt;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
        public ExerciseType Type { get; set; }
        public List<string> Muscles { get; set; }

        public Exercise(string name, string device, ExerciseType type, List<string> muscles)
        {
            Id = _nextId++;
            CreatedAt = DateTime.Now;
            Update(name, device, type, muscles);
        }
        public void Update(string name, string device, ExerciseType type, List<string> muscles)
        {
            if (name == null) name = "";
            if (device == null) device = "";
            name = name.Trim();
            device = device.Trim();
            if (name.Length < MinNameLength)
                throw new Exception("Ime vaje mora imeti vsaj 2 znaka.");
            if (device.Length == 0)
                throw new Exception("Izberi napravo.");
            if (muscles == null || muscles.Count == 0)
                throw new Exception("Izberi vsaj eno mišico.");

            Name = name;
            Device = device;
            Type = type;
            Muscles = muscles;
        }
        public static void ResetIds()
        {
            _nextId = 1;
        }
        public override string ToString()
        {
            return $"{Name} ({Type}, {Device})";
        }
        ~Exercise()
        {
            // naredi destruktor pri vaji
            //popravci celo vajo dodaj objekte.
        }
    }
}


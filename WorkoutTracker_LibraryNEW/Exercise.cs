using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class Exercise
    {
        public const int MinNameLength = 2; // const — konstantna vrednost, znana ob kompilaciji
        private static int _nextId = 1; // static — skupen stevec za vse Exercise objekte
        public readonly DateTime CreatedAt; // readonly — nastavljen samo v konstruktorju, potem nespremenljiv

        public int Id { get; private set; }

        // lastnost z logiko v setterju — validacija imena
        private string _name;
        public string Name
        {
            get { return _name; }
            private set
            {
                string val = value ?? "";
                val = val.Trim();
                if (val.Length < MinNameLength)
                    throw new Exception("Ime vaje mora imeti vsaj 2 znaka.");
                _name = val;
            }
        }

        // lastnost z logiko v setterju — validacija naprave
        private string _device;
        public string Device
        {
            get { return _device; }
            private set
            {
                string val = value ?? "";
                val = val.Trim();
                if (val.Length == 0)
                    throw new Exception("Izberi napravo.");
                _device = val;
            }
        }

        public ExerciseType Type { get; private set; }
        public List<string> Muscles { get; private set; }

        // konstruktor — inicializacija z validacijo preko Update()
        public Exercise(string name, string device, ExerciseType type, List<string> muscles)
        {
            Id = _nextId++;
            CreatedAt = DateTime.Now; // readonly se nastavi tu
            Update(name, device, type, muscles);
        }
        // objektna metoda — posodobi podatke vaje
        public void Update(string name, string device, ExerciseType type, List<string> muscles)
        {
            if (muscles == null || muscles.Count == 0)
                throw new Exception("Izberi vsaj eno mišico.");

            Name = name;     // validacija se zgodi v setterju
            Device = device; // validacija se zgodi v setterju
            Type = type;
            Muscles = muscles; //objekt seznama
        }
        // staticna metoda — resetira stevec ID-jev za vse Exercise objekte
        public static void ResetIds()
        {
            _nextId = 1;
        }
        // virtualna metoda — omogoca override v podrazredih (StrengthExercise)
        public override string ToString()
        {
            return $"{Name} ({Type}, {Device})";
        }
        // destruktor — klice se ob garbage collection
        ~Exercise()
        {
            Console.WriteLine("Exercise objekt uničen: " + Name);
        }
    }
}


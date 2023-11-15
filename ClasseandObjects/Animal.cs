using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseandObjects
{
    class Animal
    {
        private string name;
        private string sound;
        public static int numOfAnimals = 0;
        public const string SHELTER = "Derek's home for animals";
        public readonly int idNum;

        public Animal() : this("No name", "no sound") { }

        public Animal(string name) : this(name, "no sound") { }

        public Animal(string name, string souns)
        {
            SetName(name);
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

        public void SetName(string name)
        {
            if(!name.Any(char.IsDigit))
            {
                this.name = name;
            } else
            {
                this.name = "No name";
                Console.WriteLine("Name can't contain numbers");
            }

        }

        public string GetName()
        {
            return name;
        }

        // property example
        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                } else
                {
                    sound = value;
                }
            }
        }

        public string Owner { get; set; } = "No owner";

        public static int numOfAnimals
        {
            get { return numOfAnimals; }
        }
    }
}

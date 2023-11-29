using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        private String name;
        protected String sound;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public string Name
        {
            get { return name; }
            set
            {
                if (!name.Any(char.IsDigit))
                {
                    sound = "No name";
                    Console.WriteLine("Can't use numbers in name");
                }
                else
                {
                    sound = value;
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (!name.Any(char.IsDigit))
                {
                    sound = "No name";
                    Console.WriteLine("Can't use numbers in name");
                }
                else
                {
                    sound = value;
                }
            }
        }

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;    
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal() : this("No name", "No sound") { }
        public Animal(string name) : this(name, "No sound") { }
        public Animal(string name,string sound)
        {
            
        }




    }
}

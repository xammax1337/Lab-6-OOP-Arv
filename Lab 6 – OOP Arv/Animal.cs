using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Animal
    {
        public bool HasTail { get; set; }

        public string Specie { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Habitat { get; set; }

        public Animal(bool hasTail, string specie, string gender, int age, string habitat ) 
        {
            HasTail = hasTail;
            Specie = specie;
            Gender = gender;
            Age = age;
            Habitat = habitat;
        }

        public void Sleeping()
        {
            Console.WriteLine($"The {Specie} is sleeping. zzz ZZZ");
        }

        public void Running() 
        {
            Console.WriteLine($"The {Specie} is running.");
        }

        public void Hungry()
        {
            Console.WriteLine($"The {Specie} is hungry.");
        }
    }
}

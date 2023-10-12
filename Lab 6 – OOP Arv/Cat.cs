using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Cat : Animal
    {
        public bool CatRace { get; set; }
        public Cat(bool hasTail, string specie, string gender, int age, string habitat, bool catRace) : base(hasTail, specie, gender, age, habitat)
        {
            CatRace = catRace;
        }

        public void Hunting()
        {
            Console.WriteLine($"The {CatRace} is on a hunt");
        }
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
}

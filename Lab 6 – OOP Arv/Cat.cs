using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Cat : Animal
    {
        public bool OutsideCat { get; set; }
        public Cat(bool hasTail, string gender, int age, bool outsideCat) : base(hasTail, "Cat", gender, age, "Anywhere")
        {
            OutsideCat = outsideCat;
        }

        public void Hunting()
        {
            Console.WriteLine($"The {Specie} is on a hunt");
        }
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}

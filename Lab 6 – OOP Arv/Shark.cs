using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Shark : Fish
    {
        public double Length { get; set; }

        public Shark(bool hasTail, string gender, int age,  double length) : base(hasTail, gender, age, "Carnivore")
        {
            Length = length;
        }

        public void Attack()
        {
            Console.WriteLine($"The {Length}cm long shark attacks!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Fish : Animal
    {
        public string Diet {  get; set; }
        public Fish(bool hasTail, string gender, int age, string diet) : base(hasTail, "Fish", gender, age, "Ocean")
        {
            Diet = diet;
        }
        //Methods for all fishes
        public void SwimAround()
        {
            Console.WriteLine("Fish is swimming");
        }
        public void MakeSound()
        {
            Console.WriteLine("blurp, blur, blu");
        }
    }
}

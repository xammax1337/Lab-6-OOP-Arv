using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Ape : Animal
    {
        public int Bananas { get; set; } //Set how many banans they eat per day

        public Ape(bool hasTail, string specie, string gender, int age, string habitat, int bananas) : base (hasTail, "Ape", gender, age, "Jungle")
        {
            Bananas = bananas;
        }
        public void PeelBanana()
        {
            Console.WriteLine("The ape is peeling a banana");
        }
        public void MakeSound()
        {
            Console.WriteLine("hoo hoo hah ooh ha");
        }
    }
}

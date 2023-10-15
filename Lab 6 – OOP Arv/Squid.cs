using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Squid : Fish
    {
        public int Tentacles { get; set; }

        public Squid(string gender, int age, string diet, int tentacles) : base(false, gender, age, diet)
        {
            Tentacles = tentacles;
        }

        public void InkDefense() 
        {
            Console.WriteLine($"The squid creates a cloud of ink to escape");
        }

    }
}

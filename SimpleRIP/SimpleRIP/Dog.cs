using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRIP
{
    public class Dog : Animal
    {
        public Dog() : base("Dog", "Baw baw", "Pedegry") { }

        public override void GetInfo()
        {
            Console.WriteLine("Dog", "Baw baw", "Pedegry");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal horse = new Horse();
            Animal dog = new Dog();
            Animal cat = new Cat();

            PrintInfo.PrintGetInfo(horse);
            PrintInfo.PrintGetInfo(dog);
            PrintInfo.PrintGetInfo(cat);

            Console.ReadLine();
        }
    }
}

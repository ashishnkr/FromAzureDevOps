using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRIP
{
    public abstract class Animal
    { 
        public Animal(string name = "No Name", string sound = "No Sound", string food = "No Food")
        {
            Name = name;
            Sound = sound;
            Food = food;
        }

        public string Name { get ; private set ; }
        public string Sound { get; private set; }
        public object Food { get; private set; }

        public abstract void GetInfo();
    }
}

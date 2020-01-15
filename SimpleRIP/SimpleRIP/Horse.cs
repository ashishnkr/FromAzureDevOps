using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRIP
{
    public class Horse : Animal
    {
        public Horse() : base("Horse", "EHHHH", "Grass") { }

        public override void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}

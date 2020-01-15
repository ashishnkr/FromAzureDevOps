using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRIP
{
    public class Cat : Animal
    {
        public Cat() : base("Cat", "Meuw", "Meat") { }

        public override void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}

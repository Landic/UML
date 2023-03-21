using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal class Lion : ICarnivore
    {
        public double Power { get; set; }

        public Lion()
        {
            Power = 0;
        }

        public void Eat()
        {
            Power += 10;
        }
    }
}

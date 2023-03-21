using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal class Wolf : ICarnivore
    {
        public double Power { get; set; }

        public Wolf()
        {
            Power = 0;
        }

        public void Eat()
        {
            Power += 10;
        }
    }
}

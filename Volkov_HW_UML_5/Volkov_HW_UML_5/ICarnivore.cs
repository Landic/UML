using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal interface ICarnivore
    {
        double Power { get; set; }
        void Eat();
    }
}

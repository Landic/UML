using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_8_UML
{
    internal interface IComponent
    {
        void Add(IComponent obj);
        int GetPrice();
        void Remove(IComponent obj);

        void Display(int depth = 0);
    }
}

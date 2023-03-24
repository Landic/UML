using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Volkov_HW_8_UML
{
    internal class Composite : IComponent
    {
        List<IComponent> components;
        string name;
        int price;

        public Composite(string name)
        {
            components= new List<IComponent>();
            this.name = name;
        }

        public void Add(IComponent obj)
        {
            components.Add(obj);
        }

        public int GetPrice()
        {
            return price;
        }

        public void Remove(IComponent obj)
        {
            components.Remove(obj);
        }
        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth)}{name}");

            foreach (var i in components)
            {
                i.Display(depth + 2);
            }
        }
    }
}

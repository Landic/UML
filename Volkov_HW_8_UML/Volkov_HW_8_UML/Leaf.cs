using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_8_UML
{
    internal class Leaf : IComponent
    {
        string name;
        int price;

        public Leaf(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public void Add(IComponent obj)
        {
            Console.WriteLine("Cannot add component!");
        }

        public int GetPrice()
        {
            throw new NotImplementedException();
        }

        public void Remove(IComponent obj)
        {
            Console.WriteLine("Cannot remove component!");
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth)}{name} {price}");
        }
    }
}

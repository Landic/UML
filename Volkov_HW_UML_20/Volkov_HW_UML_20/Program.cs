using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IElement house = new House();

            IVisitor visitor = new Agent();

            Client.ClientCode(house, visitor);

            IElement bank = new Bank();

            Client.ClientCode(bank, visitor);

            IElement factory = new Factory();

            Client.ClientCode(factory, visitor);
        }
    }
}

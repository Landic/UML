using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logistics obj = new Logistics();
            obj.Logic(new CreateTruck());
            obj.Logic(new CreatePlane());
            obj.Logic(new CreateShip());
        }
    }
}

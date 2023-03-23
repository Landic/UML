using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine obj = new Engine("Diesel");
            Transport obj2 = new Vessel("Container", "Vessel", obj);
            Vessel obj3 = (Vessel)obj2.Clone();
            Console.WriteLine(obj2);
            Console.WriteLine("----------------------");
            Console.WriteLine(obj3);

        }
    }
}

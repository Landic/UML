using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MilitaryFactory factory = new MilitaryFactory();
            MilitaryBase obj = new HeavyTransport();
            MilitaryBase obj2 = new Airplane();
            MilitaryBase obj3 = new Airplane();
            factory.Show(obj);
            factory.Show(obj2);
            factory.ShowAll();
            factory.Show(obj3);
            Console.WriteLine("------------------------");
            factory.ShowAll();
        }
    }
}

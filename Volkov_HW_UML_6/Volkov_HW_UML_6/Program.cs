using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Shop.BuildCar(new FordProbe()));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(Shop.BuildCar(new UAZPatriot()));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(Shop.BuildCar(new DaewooLanos()));
            Console.WriteLine("------------------------------------");
            IBuilder obj = new DaewooLanos();
            Shop obj2 = new Shop(obj);
            obj2.BuildCar();
            Console.WriteLine(obj.GetCar());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(1000);
            IAirport airport = null;
            int choose = 0;
            Console.WriteLine("Укажите пункт чтобы мы вам подобрали транспорт");
            Console.WriteLine("1. Много времени\n2. Умеренно\n3. Опаздываю");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    airport = new Bycicle();
                    Console.WriteLine(airport.GetType().Name);
                    client.SetMoveStrategy(airport);
                    client.Move();
                    break;
                case 2:
                    airport = new Bus();
                    Console.WriteLine(airport.GetType().Name);
                    client.SetMoveStrategy(airport);
                    client.Move();
                    break;
                case 3:
                    airport = new Taxi();
                    Console.WriteLine(airport.GetType().Name);
                    client.SetMoveStrategy(airport);
                    client.Move();
                    break;
            }
        }
    }
}

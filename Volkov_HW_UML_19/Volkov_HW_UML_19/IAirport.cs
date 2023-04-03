using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Volkov_HW_UML_19
{
    internal interface IAirport
    {
        int price { get; set; }
        void Drive(int money);
    }

    internal class Taxi : IAirport
    {
        public int price { get; set; }

        public Taxi()
        {
            price = 100;
        }

        public void Drive(int money)
        {
            money -= price;
            Console.WriteLine("Стоимость такси " + price + " UAH поездка займет 15 минут");
            
        }
    }


    internal class Bus : IAirport
    {
        public int price { get; set; }

        public Bus()
        {
            price = 15;
        }

        public void Drive(int money)
        {
            money -= price;
            Console.WriteLine("Стоимость такси " + price + " UAH поездка займет 45 минут");

        }
    }


    internal class Bycicle : IAirport
    {
        public int price { get; set; }

        public Bycicle()
        {
            price = 0;
        }

        public void Drive(int money)
        {
            money -= price;
            Console.WriteLine("Стоимость такси " + price + " UAH поездка займет 1 час 30 минут");

        }
    }
}

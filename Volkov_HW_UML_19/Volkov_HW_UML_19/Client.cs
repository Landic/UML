using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_19
{
    internal class Client
    {
        int money;
        IAirport airport;

        public Client(int money)
        {
            this.money = money;
        }

        public void SetMoveStrategy(IAirport airport)
        {
            this.airport = airport;
        }

        public void Move()
        {
            if(airport == null)
            {
                Console.WriteLine("Не выбран транспорт");
            }
            else
            {
                airport.Drive(money);
            }
        }

        public override string ToString()
        {
            return $"Баланс -> {money}\nТранспорт -> {airport.GetType().Name}";
        }
    }
}

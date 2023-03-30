using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RomaniaCollection collection = new RomaniaCollection();
            collection.AddAttractions("Колизей");
            collection.AddAttractions("Фонтан Треви");
            collection.AddAttractions("Пантеон");

            foreach(var i in collection)
            {
                Console.WriteLine(i);
            }

            if (collection.GetItems().Contains("Колизей"))
            {
                Console.WriteLine("Пешком по навигатору 2 часа\nЕсли у вас есть бюджет можете потратить на экскурсовода и доберетесь за 50 минут");
            }
        }
    }
}

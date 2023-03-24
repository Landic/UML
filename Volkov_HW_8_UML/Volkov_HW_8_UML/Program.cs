using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_8_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Composite obj = new Composite("Приемная");
            obj.Add(new Leaf("Теплые тона", 500));
            Composite obj2 = new Composite("Журнальный столик");
            for (int i = 0; i < 10; i++)
            {
                obj2.Add(new Leaf("Компьютерный мир", 60));
            }
            obj.Add(obj2);
            obj.Add(new Leaf("Мягкий диван", 1000));
            Composite obj3 = new Composite("Стол секретаря");
            Composite obj4 = new Composite("ПК");
            obj4.Add(new Leaf("Жесткий диск", 700));
            obj3.Add(obj4);
            obj3.Add(new Leaf("Офисный инструментарий", 200));
            obj.Add(obj3);
            obj.Add(new Leaf("Кулер с теплой и холодной водой", 1000));
            obj.Display();
        }
    }
}

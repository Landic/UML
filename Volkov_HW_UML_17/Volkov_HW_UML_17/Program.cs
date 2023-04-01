using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text obj = new Text();
            CareTaker obj2 = new CareTaker();

            obj.SetText("Hello");
            obj2.AddMomento(obj.Save());

            obj.SetText("Hi");

            obj2.AddMomento(obj.Save());

            obj.SetText("Jack");

            obj2.AddMomento(obj.Save());

            Console.WriteLine("-----------------------");
            Console.WriteLine(obj.ToString());
            Console.WriteLine("-----------------------");
            obj.Undo(obj2.GetMemento(1));
            obj.Redo(obj2.GetMemento(2));
            Console.WriteLine(obj.ToString());
            Console.WriteLine("-----------------------");

            obj2.History();
        }
    }
}

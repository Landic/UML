using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPG obj = new Human();
            obj = new HumanWarior(obj);
            Console.WriteLine(obj.GetName() + " " + obj.GetHealth() + " " + obj.GetArmor() + " " + obj.GetAttack() + " " + obj.GetSpeed());
            RPG obj2 = new Elf();
            obj2 = new EvilMage(obj2);
            Console.WriteLine(obj2.GetName() + " " + obj2.GetHealth() + " " + obj2.GetArmor() + " " + obj2.GetAttack() + " " + obj2.GetSpeed());
        }
    }
}

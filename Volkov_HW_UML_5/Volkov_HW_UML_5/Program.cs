using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld obj = new AnimalWorld(new Africa(), 70, 60);

            Console.WriteLine("Wilde beest - " + obj.GetWeight() + " " + obj.GetLife() + "\nLion - " + obj.GetPower());
            obj.MealsHerbivores();
            Console.WriteLine("Wilde beest - " + obj.GetWeight() + " " + obj.GetLife() + "\nLion - " + obj.GetPower());
            obj.NutrionCarnivores();
            Console.WriteLine("Wilde beest - " + obj.GetWeight() + " " + obj.GetLife() + "\nLion - " + obj.GetPower());

            AnimalWorld obj2 = new AnimalWorld(new NorthAmerica(), 70, 60);
            Console.WriteLine("Bison - " + obj2.GetWeight() + " " + obj2.GetLife() + "\nWolf - " + obj2.GetPower());
            obj2.MealsHerbivores();
            Console.WriteLine("Bison - " + obj2.GetWeight() + " " + obj2.GetLife() + "\nWolf - " + obj2.GetPower());
            obj2.NutrionCarnivores();
            Console.WriteLine("Bison - " + obj2.GetWeight() + " " + obj2.GetLife() + "\nWolf - " + obj2.GetPower());

            AnimalWorld obj3 = new AnimalWorld(new Eurasia(), 70, 60);
            Console.WriteLine("Elk - " + obj3.GetWeight() + " " + obj3.GetLife() + "\nTiger - " + obj3.GetPower());
            obj3.MealsHerbivores();
            Console.WriteLine("Elk - " + obj3.GetWeight() + " " + obj3.GetLife() + "\nTiger - " + obj3.GetPower());
            obj3.NutrionCarnivores();
            Console.WriteLine("Elk - " + obj3.GetWeight() + " " + obj3.GetLife() + "\nTiger - " + obj3.GetPower());

        }
    }
}

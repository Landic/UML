using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal class AnimalWorld
    {
        private IHerbivore herbivore;
        private ICarnivore carnivore;

        public AnimalWorld(IContinent continent, int weight, int power)
        {
            carnivore = continent.CreateAnimalCarnivore();
            herbivore = continent.CreateAnimalHerbivore();
            carnivore.Power = power;
            herbivore.Weight = weight;
        }

        public double GetWeight()
        {
            return herbivore.Weight;
        }

        public bool GetLife() { return herbivore.Life; }

        public double GetPower() { return carnivore.Power; }

        public void MealsHerbivores()
        {
            if(herbivore.Life == true)
            {
                herbivore.EatGrass();
            }
            else
            {
                Console.WriteLine("The animal has died");
            }
        }

        public void NutrionCarnivores()
        {
            if(herbivore.Weight < carnivore.Power && herbivore.Life == true)
            {
                carnivore.Eat();
                herbivore.Life = false;
                herbivore.Weight = 0;
            }
            else
            {
                carnivore.Power -= 10;
            }
        }
    }
}

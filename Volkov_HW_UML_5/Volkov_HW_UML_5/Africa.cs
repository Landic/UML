using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal class Africa : IContinent
    {
        public ICarnivore CreateAnimalCarnivore()
        {
            return new Lion();
        }

        public IHerbivore CreateAnimalHerbivore()
        {
            return new Wildebeest();
        }
    }
}

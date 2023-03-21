using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal interface IContinent
    {
        IHerbivore CreateAnimalHerbivore();
        ICarnivore CreateAnimalCarnivore();
    }
}

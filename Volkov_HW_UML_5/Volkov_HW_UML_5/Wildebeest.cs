﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_5
{
    internal class Wildebeest : IHerbivore
    {
        public double Weight { get; set; }
        public bool Life { get; set; }

        public Wildebeest()
        {
            Life = true;
            Weight = 0;
        }

        public void EatGrass()
        {
            Weight+=10;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_4
{
    internal class CreateTruck : Creator
    {
        public override ITransport Create()
        {
            Console.WriteLine("Truck created!");
            return new Truck();
        }
    }
}

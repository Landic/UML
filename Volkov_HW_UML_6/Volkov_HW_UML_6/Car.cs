using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_6
{
    internal class Car
    {
        public string Frame { get; set; }
        public int Engine { get; set; }
        public int Wheel { get; set; }
        public string Checkpoint { get; set; }

        public override string ToString()
        {
            return $"Frame -> {Frame}\nEngine -> {Engine}\nWheel -> {Wheel}\nCheckpoint -> {Checkpoint}";
        }
    }
}

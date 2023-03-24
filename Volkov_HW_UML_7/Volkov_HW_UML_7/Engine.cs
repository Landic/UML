using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_7
{
    internal class Engine : IClone
    {
        public string TypeEngine { get; set; }

        public Engine()
        {

        }

        public Engine(string TypeEngine)
        {
            this.TypeEngine = TypeEngine;
        }

        public IClone Clone()
        {
            Engine obj = new Engine();
            obj.TypeEngine = TypeEngine;
            return obj;
        }
    }
}

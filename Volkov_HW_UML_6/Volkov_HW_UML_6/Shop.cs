using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_6
{
    internal class Shop
    {
        private IBuilder build;

        public Shop(IBuilder build)
        {
            this.build = build;
        }

        public void BuildCar()
        {
            build.BuildWheel();
            build.BuildEngine();
            build.BuildCheckpoint();
            build.BuildFrame();
        }

        public static Car BuildCar(IBuilder build)
        {
            build.BuildWheel();
            build.BuildEngine();
            build.BuildCheckpoint();
            build.BuildFrame();
            return build.GetCar();
        }
    }
}

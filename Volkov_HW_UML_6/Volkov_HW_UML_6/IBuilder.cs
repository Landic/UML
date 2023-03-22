using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_6
{
    internal interface IBuilder
    {
        void BuildFrame();
        void BuildEngine();
        void BuildWheel();
        void BuildCheckpoint();
        Car GetCar();
    }


    internal class FordProbe : IBuilder
    {
        private Car car;

        public FordProbe()
        {
            car = new Car();
        }

        public void BuildCheckpoint() => car.Checkpoint = "4 Auto";

        public void BuildEngine() => car.Engine = 160;

        public void BuildFrame() => car.Frame = "Cupe";

        public void BuildWheel() => car.Wheel = 14;

        public Car GetCar()
        {
            return car;
        }
    }

    internal class UAZPatriot : IBuilder
    {
        private Car car;

        public UAZPatriot()
        {
            car = new Car();
        }

        public void BuildCheckpoint() => car.Checkpoint = "4 Manual";

        public void BuildEngine() => car.Engine = 120;

        public void BuildFrame() => car.Frame = "Universal";

        public void BuildWheel() => car.Wheel = 16;

        public Car GetCar()
        {
            return car;
        }
    }

    internal class DaewooLanos : IBuilder
    {
        private Car car;

        public DaewooLanos()
        {
            car = new Car();
        }

        public void BuildCheckpoint() => car.Checkpoint = "5 Manual";

        public void BuildEngine() => car.Engine = 98;

        public void BuildFrame() => car.Frame = "Sedan";

        public void BuildWheel() => car.Wheel = 13;

        public Car GetCar()
        {
            return car;
        }
    }
}

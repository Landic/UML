using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_7
{
    internal abstract class Transport : IClone
    {
        public string Model { get; set; }
        public Engine engine { get; set; }

        public abstract object Clone();

        public override string ToString()
        {
            return $"Model -> {Model}\nEngine -> {engine.TypeEngine}\n";
        }

    }

    internal class Vessel : Transport
    {
        public string TypeVessel { get; set; }

        public Vessel()
        {
            Model = string.Empty;
            TypeVessel= string.Empty;
            engine = new Engine();
        }

        public Vessel(string typeVessel, string Model, Engine engine)
        {
            TypeVessel = typeVessel;
            this.Model = Model;
            this.engine = engine;
        }

        public override object Clone()
        {
            Vessel obj = (Vessel)this.MemberwiseClone();
            obj.Model = Model;
            obj.engine = (Engine)engine.Clone();
            return obj;
        }

        public override string ToString()
        {
            return base.ToString() + $"Type vessel -> {TypeVessel}\n";
        }
    }

    internal class Plane : Transport
    {
        public string Distance { get; set; }

        public Plane()
        {
            Model = string.Empty;
            Distance = string.Empty;
            engine = new Engine();
        }

        public Plane(string Distance, string Model, Engine engine)
        {
            this.Distance = Distance;
            this.Model = Model;
            this.engine = engine;
        }

        public override object Clone()
        {
            Plane obj = (Plane)this.MemberwiseClone();
            obj.Model = Model;
            obj.engine = (Engine)engine.Clone();
            return obj;
        }

        public override string ToString()
        {
            return base.ToString() + $"Distance -> {Distance}\n";
        }
    }

    internal class Auto : Transport
    {
        public string Transmission { get; set; }

        public Auto()
        {
            Model = string.Empty;
            Transmission = string.Empty;
            engine = new Engine();
        }

        public Auto(string Transmission, string Model, Engine engine)
        {
            this.Transmission = Transmission;
            this.Model = Model;
            this.engine = engine;
        }

        public override object Clone()
        {
            Auto obj = (Auto)this.MemberwiseClone();
            obj.Model = Model;
            obj.engine = (Engine)engine.Clone();
            return obj;
        }
        public override string ToString()
        {
            return base.ToString() + $"Transmission -> {Transmission}\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_11
{
    internal abstract class MilitaryBase
    {
        public int Move { get; set; }
        public int Power { get; set; }

        public void Show()
        {
            Console.WriteLine($"Move -> {Move}\nPower -> {Power}");
        }
    }


    internal class LightInfantry : MilitaryBase
    {
        public LightInfantry()
        {
            Move = 20;
            Power = 10;
        }
    }

    internal class Transport : MilitaryBase
    {
        public Transport()
        {
            Move = 70;
            Power = 0;
        }
    }

    internal class HeavyTransport : MilitaryBase
    {
        public HeavyTransport()
        {
            Move = 15;
            Power = 150;
        }
    }

    internal class LightTransport : MilitaryBase
    {
        public LightTransport()
        {
            Move = 50;
            Power = 30;
        }
    }

    internal class Airplane : MilitaryBase
    {
        public Airplane()
        {
            Move = 300;
            Power = 100;
        }
    }

    internal class MilitaryFactory
    {
        private List<MilitaryBase> list;

        public MilitaryFactory()
        {
            list = new List<MilitaryBase>();
        }

        public void Show(MilitaryBase obj)
        {
            if(!list.Contains(obj))
            {
                list.Add(obj);
            }
            list.Where(i => i == obj).FirstOrDefault().Show();
        }

        public void ShowAll()
        {
            foreach(var i in list)
            {
                Show(i);
            }
        }
    }
}

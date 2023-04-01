using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Volkov_HW_UML_16
{
    internal interface IObserver
    {
        void Update();
    }

    internal interface IShop
    {
        void AddeSubscriber(IObserver observer);
        void RemoveSubscriber(IObserver observer);
        void Notify();
    }

    internal class Shop : IShop
    {
        List<IObserver> list;

        public Shop()
        {
            list = new List<IObserver>();
        }

        public void AddeSubscriber(IObserver observer)
        {
            list.Add(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Sending event...");
            foreach(var i in list)
            {
                i.Update();
            }
        }

        public void RemoveSubscriber(IObserver observer)
        {
            list.Remove(observer);
        }

        public void Logic()
        {
            Thread.Sleep(500);
            this.Notify();
        }
    }


    internal class Subscriber : IObserver
    {
        public void Update()
        {
            Console.WriteLine("New phone in store");
        }
    }
}

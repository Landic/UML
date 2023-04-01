using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var observer = new Subscriber();
            var observer2 = new Subscriber();
            var observer3 = new Subscriber();
            var subject = new Shop();

            subject.AddeSubscriber(observer);
            subject.AddeSubscriber(observer2);
            subject.AddeSubscriber(observer3);

            subject.Logic();

        }
    }
}

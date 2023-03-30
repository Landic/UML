using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_14
{
    internal class Beatles : Participant
    {
        public Beatles(string name) : base(name) { }
        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a Beatles: ");
            base.Receive(from, message);
        }
    }
}

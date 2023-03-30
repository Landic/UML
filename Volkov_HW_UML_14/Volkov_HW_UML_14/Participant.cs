using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_14
{
    internal abstract class Participant
    {
        public AbstractChatroom ChatRoom { get; set; }
        public string Name { get; set; }

        public Participant(string Name)
        {
            this.Name = Name;
        }

        public void Send(string to, string message)
        {
            ChatRoom.Send(Name,to,message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: {message}");
        }
    }
}

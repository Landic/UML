using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractChatroom chatroom = new ChatRoom();
            Participant[] participant = new Participant[2] { new Beatles("Joe"), new Beatles("Paul")};
            for (int i = 0; i < participant.Length; i++)
            {
                chatroom.Register(participant[i]);
            }

            participant[0].Send("Paul", "Hello Paul");
            participant[1].Send("Joe", "Hello Joe");
        }
    }
}

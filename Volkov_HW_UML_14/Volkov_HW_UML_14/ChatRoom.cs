using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_14
{
    internal class ChatRoom : AbstractChatroom
    {
        Dictionary<string, Participant> participants;

        public ChatRoom()
        {
            participants = new Dictionary<string, Participant>();
        }

        public override void Register(Participant participant)
        {
            if (!participants.ContainsKey(participant.Name))
            {
                participants[participant.Name] = participant;
            }
            participant.ChatRoom = this;
        }

        public override void Send(string from, string to, string message)
        {
            if (participants.TryGetValue(to, out Participant participant) && participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}

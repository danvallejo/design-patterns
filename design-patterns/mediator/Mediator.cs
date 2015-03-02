using System.Collections.Generic;

namespace mediator
{
    public abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }

    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!participants.ContainsKey(participant.Name))
            {
                participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            var participant = participants[to];

            participant.Receive(from, message);
        }
    }
}

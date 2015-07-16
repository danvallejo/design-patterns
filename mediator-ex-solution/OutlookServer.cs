using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mediator_ex_solution
{
    public class OutlookServer
    {
        private List<MailClient> mailClients = new List<MailClient>();
        private Dictionary<string, List<MailMessage>> messages = new Dictionary<string, List<MailMessage>>();

        public void Register(MailClient client)
        {
            mailClients.Add(client);

            client.MailServer = this;
        }

        internal void Send(string from, string to, MailMessage mailMessage)
        {
            var client = mailClients.FirstOrDefault(t => t.Address == to);

            if (client != null)
            {
                client.Receive(from, mailMessage);
            }
            else
            {
                throw new Exception("Invalid address :" + to);
            }
        }
    }
}

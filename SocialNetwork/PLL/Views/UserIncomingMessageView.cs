using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Incoming messages");


            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("No incoming messages");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("From: {0}. Text message: {1}", message.SenderEmail, message.Content);
            });
        }
    }
}

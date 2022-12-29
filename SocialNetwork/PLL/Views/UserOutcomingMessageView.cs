using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserOutcomingMessageView
    {
        public void Show(IEnumerable<Message> outcomingMessages)
        {
            Console.WriteLine("Outcoming messages");

            if (outcomingMessages.Count() == 0)
            {
                Console.WriteLine("No outcoming messages");
                return;
            }

            outcomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("To: {0}. Text message: {1}", message.RecipientEmail, message.Content);
            });
        }
    }
}

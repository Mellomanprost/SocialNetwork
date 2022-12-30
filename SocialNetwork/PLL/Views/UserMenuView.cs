using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.PLL.Views
{
    public class UserMenuView
    {
        UserService userService;

        public UserMenuView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Incoming message: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Outcoming message: {0}", user.OutgoingMessages.Count());

                Console.WriteLine("View my profile information (press 1)");
                Console.WriteLine("Edit my profile (press 2)");
                Console.WriteLine("Add as friend (press 3)");
                Console.WriteLine("Send message (press 4)");
                Console.WriteLine("View incoming messages (press 5)");
                Console.WriteLine("View outcoming messages (press 6)");
                Console.WriteLine("Log out (press 7)");

                string keyValue = Console.ReadLine();

                if (keyValue == "7") break;

                switch (keyValue)
                {
                    case "1":
                    {
                        Program.userInfoView.Show(user);
                        break;
                    }
                    case "2":
                    {
                        Program.userDataUpdateView.Show(user);
                        break;
                    }
                    case "3":
                    {
                        Program.friendAddView.Show(user);
                        break;
                    }
                    case "4":
                    {
                        Program.messageSendingView.Show(user);
                        break;
                    }
                    case "5":
                    {
                        Program.userIncomingMessageView.Show(user.IncomingMessages);
                        break;
                    }
                    case "6":
                    {
                        Program.userOutcomingMessageView.Show(user.OutgoingMessages);
                        break;
                    }
                }
            }
        }
    }
}

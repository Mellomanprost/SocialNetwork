using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class MessageSendingView
    {
        MessageService messageService;
        UserService userService;

        public MessageSendingView(MessageService messageService, UserService userService)
        {
            this.messageService = messageService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var messageSendingData = new MessageSendingData();

            Console.Write("Enter the recipient's email address: ");
            messageSendingData.RecipientEmail = Console.ReadLine();

            Console.Write("Enter message (no more then 5000 characters): ");
            messageSendingData.Content = Console.ReadLine();

            messageSendingData.SenderId = user.Id;

            try
            {
                messageService.SendMessage(messageSendingData);

                SuccessMessage.Show("Message sent successfully");

                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("User not found!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Please enter a valid value!");
            }

            catch (Exception)
            {
                AlertMessage.Show("An error occurred while sending the message!");
            }

        }
    }
}

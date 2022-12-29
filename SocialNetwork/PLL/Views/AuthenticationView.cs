using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;

        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Enter email:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Enter password:");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var user = this.userService.Authenticate(authenticationData);

                SuccessMessage.Show("Log in completed successfully!");
                SuccessMessage.Show("Welcome " + user.FirstName);

                Program.userMenuView.Show(user);
            }

            catch (WrongPasswordException)
            {
                AlertMessage.Show("Password is not correct!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("User not found!");
            }
        }
    }
}

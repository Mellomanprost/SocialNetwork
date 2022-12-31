using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddView
    {
        FriendService friendService;
        UserService userService;

        public FriendAddView(FriendService friendService, UserService userService)
        {
            this.friendService = friendService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var addFriendData = new FriendAddData();

            Console.Write("Enter your friend's email address: ");
            addFriendData.FriendEmail = Console.ReadLine();

            addFriendData.senderFriendshipUserId = user.Id;

            try
            {
                friendService.AddFriend(addFriendData);

                SuccessMessage.Show("Successfully added to friends!");  // Добавить имя друга (Иван успешно добавлен в друзья!)

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
                AlertMessage.Show("An error occurred while trying to add friends!");
            }

        }
    }
}

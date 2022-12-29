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
    public class UserDataUpdateView
    {
        UserService userService;
        public UserDataUpdateView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            Console.Write("My name is:");
            user.FirstName = Console.ReadLine();

            Console.Write("My last name is:");
            user.LastName = Console.ReadLine();

            Console.Write("Link on my photo:");
            user.Photo = Console.ReadLine();

            Console.Write("My favourite film is:");
            user.FavoriteMovie = Console.ReadLine();

            Console.Write("My favourite book is:");
            user.FavoriteBook = Console.ReadLine();

            this.userService.Update(user);

            SuccessMessage.Show("Your profile update successfully!");
        }
    }
}

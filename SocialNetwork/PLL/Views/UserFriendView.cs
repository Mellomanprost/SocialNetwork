using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<Friend> allFriends)
        {
            Console.WriteLine("Friend list");


            if (allFriends.Count() == 0)
            {
                Console.WriteLine("No friends yet.");
                return;
            }

            allFriends.ToList().ForEach(friend =>
            {
                Console.WriteLine("{0} is your friend", friend.Friend_Id);  // Сделать отображение имени друга
            });
        }
    }
}

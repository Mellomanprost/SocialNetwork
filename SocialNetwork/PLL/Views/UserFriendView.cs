using SocialNetwork.BLL.Models;

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
                Console.WriteLine("User with ID{0} is your friend", friend.Friend_Id);  // Сделать отображение имени друга
            });
        }
    }
}

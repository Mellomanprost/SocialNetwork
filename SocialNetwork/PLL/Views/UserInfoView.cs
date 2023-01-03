using SocialNetwork.BLL.Models;

namespace SocialNetwork.PLL.Views
{
    public class UserInfoView
    {
        public void Show(User user)
        {
            Console.WriteLine("My profile info");
            Console.WriteLine("My Id: {0}", user.Id);
            Console.WriteLine("My name is: {0}", user.FirstName);
            Console.WriteLine("My last name is: {0}", user.LastName);
            Console.WriteLine("My password: {0}", user.Password);
            Console.WriteLine("My email: {0}", user.Email);
            Console.WriteLine("Link on my photo: {0}", user.Photo);
            Console.WriteLine("My favourite film is: {0}", user.FavoriteMovie);
            Console.WriteLine("My favourite book is: {0}", user.FavoriteBook);
        }
    }
}

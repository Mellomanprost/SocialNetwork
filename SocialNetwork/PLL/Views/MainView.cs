namespace SocialNetwork.PLL.Views
{
    public class MainView
    {
        public void Show()
        {
            Console.WriteLine("Log In (press 1)");
            Console.WriteLine("Sign Up (press 2)");

            switch (Console.ReadLine())
            {
                case "1":
                {
                    Program.authenticationView.Show();
                    break;
                }

                case "2":
                {
                    Program.registrationView.Show();
                    break;
                }
            }
        }
    }
}

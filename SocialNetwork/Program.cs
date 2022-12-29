using System;
using System.Runtime.CompilerServices;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;


namespace SocialNetwork;

class Program
{
    static MessageService messageService;
    static UserService userService;
    public static MainView mainView;
    public static RegistrationView registrationView;
    public static AuthenticationView authenticationView;
    public static UserMenuView userMenuView;
    public static UserInfoView userInfoView;
    public static UserDataUpdateView userDataUpdateView;
    public static MessageSendingView messageSendingView;
    public static UserIncomingMessageView userIncomingMessageView;
    public static UserOutcomingMessageView userOutcomingMessageView;

    static void Main(string[] args)
    {
        userService = new UserService();
        messageService = new MessageService();

        mainView = new MainView();
        registrationView = new RegistrationView(userService);
        authenticationView = new AuthenticationView(userService);
        userMenuView = new UserMenuView(userService);
        userInfoView = new UserInfoView();
        userDataUpdateView = new UserDataUpdateView(userService);
        messageSendingView = new MessageSendingView(messageService, userService);
        userIncomingMessageView = new UserIncomingMessageView();
        userOutcomingMessageView = new UserOutcomingMessageView();

        while (true)
        {
            mainView.Show();
        }
    }

    #region old version

    //public static UserService userService = new UserService();

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Welcome to social network!");

    //    while (true)
    //    {
    //        Console.WriteLine("Log In (press 1)");
    //        Console.WriteLine("Sign Up (press 2)");

    //        switch (Console.ReadLine())
    //        {
    //            case "1":
    //                {
    //                    var authenticationData = new UserAuthenticationData();

    //                    Console.WriteLine("Enter your email:");
    //                    authenticationData.Email = Console.ReadLine();

    //                    Console.WriteLine("Enter password:");
    //                    authenticationData.Password = Console.ReadLine();

    //                    try
    //                    {
    //                        User user = userService.Authenticate(authenticationData);

    //                        Console.ForegroundColor = ConsoleColor.Green;
    //                        Console.WriteLine("Log in completed successfully! Welcome {0}", user.FirstName);
    //                        Console.ForegroundColor = ConsoleColor.White;

    //                        while (true)
    //                        {
    //                            Console.WriteLine("View your profile information (press 1)");
    //                            Console.WriteLine("Edit profile (press 2)");
    //                            Console.WriteLine("Add as friend (press 3)");
    //                            Console.WriteLine("Send message (press 4)");
    //                            Console.WriteLine("Log out (press 5)");

    //                            switch (Console.ReadLine())
    //                            {
    //                                case "1":
    //                                    {
    //                                        Console.ForegroundColor = ConsoleColor.Green;
    //                                        Console.WriteLine("Information about my profile");
    //                                        Console.WriteLine("My identification number: {0}", user.Id);
    //                                        Console.WriteLine("My first name: {0}", user.FirstName);
    //                                        Console.WriteLine("My last name: {0}", user.LastName);
    //                                        Console.WriteLine("My password: {0}", user.Password);
    //                                        Console.WriteLine("My email: {0}", user.Email);
    //                                        Console.WriteLine("Link to my photo: {0}", user.Photo);
    //                                        Console.WriteLine("My favorite film: {0}", user.FavoriteMovie);
    //                                        Console.WriteLine("My favorite book: {0}", user.FavoriteBook);
    //                                        Console.ForegroundColor = ConsoleColor.White;
    //                                        break;
    //                                    }
    //                                case "2":
    //                                    {
    //                                        Console.Write("My first name is:");
    //                                        user.FirstName = Console.ReadLine();

    //                                        Console.Write("My last name is:");
    //                                        user.LastName = Console.ReadLine();

    //                                        Console.Write("Link to my photo is:");
    //                                        user.Photo = Console.ReadLine();

    //                                        Console.Write("My favorite film is:");
    //                                        user.FavoriteMovie = Console.ReadLine();

    //                                        Console.Write("My favorite book is:");
    //                                        user.FavoriteBook = Console.ReadLine();

    //                                        userService.Update(user);

    //                                        Console.ForegroundColor = ConsoleColor.Green;
    //                                        Console.WriteLine("Your profile is successfully updated!");
    //                                        Console.ForegroundColor = ConsoleColor.White;

    //                                        break;
    //                                    }
    //                            }
    //                        }

    //                    }
    //                    catch (WrongPasswordException)
    //                    {
    //                        Console.ForegroundColor = ConsoleColor.Red;
    //                        Console.WriteLine("Passwort is not correct!");
    //                        Console.ForegroundColor = ConsoleColor.White;
    //                    }
    //                    catch (UserNotFoundException)
    //                    {
    //                        Console.ForegroundColor = ConsoleColor.Red;
    //                        Console.WriteLine("User not found!");
    //                        Console.ForegroundColor = ConsoleColor.White;
    //                    }

    //                    break;
    //                }

    //            case "2":
    //                {
    //                    var userRegistrationData = new UserRegistrationData();

    //                    Console.WriteLine("Enter your name to create a new profile:");
    //                    userRegistrationData.FirstName = Console.ReadLine();

    //                    Console.Write("Your last name:");
    //                    userRegistrationData.LastName = Console.ReadLine();

    //                    Console.Write("Password:");
    //                    userRegistrationData.Password = Console.ReadLine();

    //                    Console.Write("Email:");
    //                    userRegistrationData.Email = Console.ReadLine();

    //                    try
    //                    {
    //                        userService.Register(userRegistrationData);

    //                        Console.ForegroundColor = ConsoleColor.Green;
    //                        Console.WriteLine(
    //                            "Your profile has been successfully created. Now you can log in with your credentials.");
    //                        Console.ForegroundColor = ConsoleColor.White;
    //                    }
    //                    catch (ArgumentNullException)
    //                    {
    //                        Console.WriteLine("Please enter a valid value.");
    //                    }
    //                    catch (Exception)
    //                    {
    //                        Console.WriteLine("An error occurred while registering.");
    //                    }

    //                    break;
    //                }
    //        }
    //    }
    //}

    #endregion
}
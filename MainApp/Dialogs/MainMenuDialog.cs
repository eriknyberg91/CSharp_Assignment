using Business.Interfaces;
using Business.Models;
using MainApp.Interfaces;

namespace MainApp.Dialogs;

public class MainMenuDialog(IUserService userService) : IMainMenuDialog
{

    private readonly IUserService _userService = userService;
    public void ShowMenuDialog()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("------------- USER MANAGEMENT -------------");
            Console.WriteLine("1. Create New User");
            Console.WriteLine("2. View All Users");
            Console.WriteLine(" ------------- ");
            Console.Write("Enter option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateUserOption();
                    break;
                case "2":
                    ViewAllUsersOption();
                    break;
            }
        }
    }

    void CreateUserOption()
    {
        var user = new User();

        Console.Clear();
        
        Console.WriteLine("------------- CREATE NEW USER ------------- ");

        Console.Write("Enter First Name:");
        user.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name:");
        user.LastName = Console.ReadLine();

        Console.Write("Enter Email:");
        user.Email = Console.ReadLine();

        Console.Write("Enter Phonenumber:");
        user.PhoneNumber = Console.ReadLine();

        Console.Write("Enter Street Address");
        user.StreetAddress = Console.ReadLine();

        Console.Write("Enter Postal Code:");
        user.PostalCode = Console.ReadLine();

        Console.Write("Enter City:");
        user.City = Console.ReadLine();

        _userService.CreateUser(user);
    }
    void ViewAllUsersOption()
    {
        Console.Clear();
        Console.WriteLine("--- USERS ---");
        foreach(var user in _userService.GetUsersFromList())
        {
            Console.WriteLine($"{user.FirstName}");
            Console.WriteLine($"{user.Id}");
        }

        Console.ReadKey();
    }
}

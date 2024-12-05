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

        // First Name
        while (true)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine()!.Trim();
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                user.FirstName = firstName;
                break;
            }
            Console.WriteLine("First name cannot be empty. Please try again.");
        }

        // Last Name
        while (true)
        {
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine()!.Trim();
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                user.LastName = lastName;
                break;
            }
            Console.WriteLine("Last name cannot be empty. Please try again.");
        }

        // Email
        while (true)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine()!.Trim();
            if (!string.IsNullOrWhiteSpace(email))
            {
                user.Email = email;
                break;
            }
            Console.WriteLine("Email cannot be empty. Please try again.");
        }

        // Phone Number
        while (true)
        {
            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine()!.Trim();
            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                user.PhoneNumber = phoneNumber;
                break;
            }
            Console.WriteLine("Phone number cannot be empty. Please try again.");
        }

        // Street Address
        while (true)
        {
            Console.Write("Enter Street Address: ");
            string streetAddress = Console.ReadLine()!.Trim();
            if (!string.IsNullOrWhiteSpace(streetAddress))
            {
                user.StreetAddress = streetAddress;
                break;
            }
            Console.WriteLine("Street address cannot be empty. Please try again.");
        }

        // Postal Code
        while (true)
        {
            Console.Write("Enter Postal Code: ");
            string postalCode = Console.ReadLine()!.Trim();
            if (!string.IsNullOrWhiteSpace(postalCode))
            {
                user.PostalCode = postalCode;
                break;
            }
            Console.WriteLine("Postal code cannot be empty. Please try again.");
        }

        // City
        while (true)
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine()!.Trim();
            if (!string.IsNullOrWhiteSpace(city))
            {
                user.City = city;
                break;
            }
            Console.WriteLine("City cannot be empty. Please try again.");
        }

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

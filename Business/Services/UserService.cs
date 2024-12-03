using System.Collections;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class UserService : IUserService
{
    private readonly List<User> _users;
    
    public UserService ()
    {
        _users = new List<User> (); //Ersätt med hämtning av users från fil när fileservice är på plats
    }

    public void CreateUser(User user)
    {
        user.Id = Guid.NewGuid().ToString();
        _users.Add(user);
    }


    public IEnumerable<User> GetUsersFromList()
    {
        return _users;
    }

    
}

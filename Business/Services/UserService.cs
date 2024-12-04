using System.Collections;
using System.Text.Json;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class UserService : IUserService
{
    private readonly List<User> _users;
    private readonly IFileService _fileService;
    
    public UserService (IFileService fileService)
    {
        _fileService = fileService;
        
        try
        {
            _users = JsonSerializer.Deserialize<List<User>>(_fileService.GetFile());
        }

        catch
        {
            _users = [];
        }
    }

    public void CreateUser(User user)
    {
        user.Id = Guid.NewGuid().ToString();
        _users.Add(user);
        _fileService.SaveToFile(JsonSerializer.Serialize(_users));
    }


    public IEnumerable<User> GetUsersFromList()
    {
        return _users;
    }

    
}

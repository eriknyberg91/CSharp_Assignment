using Business.Services;
using Business.Models;


namespace Business.Tests.Services;
public class UserServiceTests
{

    private readonly UserService _userService;

    public UserServiceTests()
    {
        _userService = new UserService(new FileService());
    }


    [Fact]
    public void GetUsersFromList_ReturnsListOfUsers()
    {
        // Arrange
        var user = new User { FirstName = "testuser" };
        _userService.CreateUser(user);

        // Act
        var result = _userService.GetUsersFromList();

        // Assert
        Assert.NotNull(result);
        Assert.IsAssignableFrom<IEnumerable<User>>(result);
        Assert.Contains(result, u => u.FirstName == "testuser");

    }

    [Fact]
    public void CreateUser_ShouldCreateUser()
    {
        // Arrange
        var user = new User { FirstName = "testuser" };
        _userService.CreateUser(user);

        // Act
        var users = _userService.GetUsersFromList();
        var createdUser = users.FirstOrDefault(u => u.FirstName == "testuser");

        //Assert
        Assert.NotNull(createdUser);
        Assert.Equal("testuser", createdUser.FirstName);
    }


}

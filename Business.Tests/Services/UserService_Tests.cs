using Business.Services;
using Business.Models;


namespace Business.Tests.Services;
public class UserServiceTests
{
    [Fact]
    public void GetUsersFromList_ReturnsListOfUsers()
    {
        // Arrange
        var userService = new UserService(new FileService());

        // Act
        var result = userService.GetUsersFromList();

        // Assert
        Assert.NotNull(result);
        Assert.IsAssignableFrom<IEnumerable<User>>(result);
    }
}

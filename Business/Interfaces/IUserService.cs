using System.Collections;

namespace Business.Interfaces;

public interface IUserService
{
    public void CreateUser();

    public void AddUserToList();
    public IEnumerable GetUsersFromList();
}

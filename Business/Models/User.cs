

namespace Business.Models;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string StreetAddress { get; set; }
    public int PostalCode { get; set; }
    public string City { get; set; }
}

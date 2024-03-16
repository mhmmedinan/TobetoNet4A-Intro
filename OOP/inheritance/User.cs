using OOP.GenericType;

namespace OOP.inheritance;

public class User:BaseEntity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool Status { get; set; }
    
}

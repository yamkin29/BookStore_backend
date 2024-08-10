namespace BookStore.Core.Models;

public class User
{
    public const int MAX_EMAIL_LENGTH = 250;
    
    public Guid Id { get; }
    
    public string Email { get; }

    public string Password { get; }

    public string FirstName { get; }
    
    public string LastName  { get; }

    public User(Guid id, string email, string password, string firstName, string lastName)
    {
        Id = id;
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
    }

    public static (User registerModel, string error) Create(Guid id, string email, string password, string firstName, string lastName)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(email) || email.Length  > MAX_EMAIL_LENGTH)
        {
            error  = "Email cannot be null or empty";
        }
        
        var registerModel  = new User(id, email, password, firstName, lastName);
        
        return (registerModel, error);
    }
}
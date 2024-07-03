namespace BookStore.Core.Models;

public class LoginModel
{
    public const int MAX_EMAIL_LENGTH = 250;
    
    public string Email { get; }

    public string Password { get; }

    public LoginModel(string email, string password)
    {
        Email = email;
        Password = password;
    }
    
    public static (LoginModel registerModel, string error) Create(string email, string password)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(email) || email.Length  > MAX_EMAIL_LENGTH)
        {
            error  = "Title cannot be null or empty";
        }
        
        var loginModel= new LoginModel(email, password);
        
        return (loginModel, error);
    }
}
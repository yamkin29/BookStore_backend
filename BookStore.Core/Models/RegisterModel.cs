﻿namespace BookStore.Core.Models;

public class RegisterModel
{
    public const int MAX_EMAIL_LENGTH = 250;
    
    public string Email { get; }

    public string Password { get; }

    public string FirstName { get; }
    
    public string LastName  { get; }

    public RegisterModel(string email, string password, string firstName, string lastName)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
    }

    public static (RegisterModel registerModel, string error) Create(string email, string password, string firstName, string lastName)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(email) || email.Length  > MAX_EMAIL_LENGTH)
        {
            error  = "Title cannot be null or empty";
        }
        
        var registerModel  = new RegisterModel(email, password, firstName, lastName);
        
        return (registerModel, error);
    }
}
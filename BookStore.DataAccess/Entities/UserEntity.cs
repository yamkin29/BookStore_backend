﻿using Microsoft.AspNetCore.Identity;

namespace BookStore.DataAccess.Entities;

public class UserEntity : IdentityUser
{
    public Guid Id { get; set; }

    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
}
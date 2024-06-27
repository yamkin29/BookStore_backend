using Microsoft.AspNetCore.Identity;

namespace BookStore.DataAccess.Entities;

public class UserEntity : IdentityUser
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public DateTime DateOfBirth { get; set; }
}
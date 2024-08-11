using BookStore.Core.Models;

namespace BookStore.Core.Abstractions;

public interface IUsersService
{
    Task<List<User>> GetAllUsers();
    Task<Guid> CreateUser(User user);
    Task<Guid> UpdateUser(Guid id, string email, string password, string firstName, string lastName);
    Task<Guid> DeleteUser(Guid id);
}
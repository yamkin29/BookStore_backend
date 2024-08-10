using BookStore.Core.Models;
using Microsoft.AspNetCore.Builder;

namespace BookStore.Core.Abstractions;

public interface IUsersRepository
{
    Task<List<User>> Get();
    Task<Guid> Create(User user);
    Task<Guid> Update(Guid id, string email, string password, string firstName, string lastName);
    Task<Guid> Delete(Guid id);
}
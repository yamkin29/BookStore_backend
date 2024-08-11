using BookStore.Core.Abstractions;
using BookStore.Core.Models;

namespace BookStore.Application.Services;

public class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _usersRepository.Get();
    }

    public async Task<Guid> CreateUser(User user)
    {
        return await _usersRepository.Create(user);
    }

    public async Task<Guid> UpdateUser(Guid id, string email, string password, string firstName, string lastName)
    {
        return await _usersRepository.Update(id, email, password, firstName, lastName);
    }

    public async Task<Guid> DeleteUser(Guid id)
    {
        return await _usersRepository.Delete(id);
    }
}
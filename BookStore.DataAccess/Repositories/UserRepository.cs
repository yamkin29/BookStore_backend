using BookStore.Core.Abstractions;
using BookStore.Core.Models;
using BookStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Repositories;

public class UserRepository : IUsersRepository
{
    private readonly BookStoreDbContext _context;

    public UserRepository(BookStoreDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<User>> Get()
    {
        var userEntities = await _context.Users
            .AsNoTracking()
            .ToListAsync();
        
        var users = userEntities
            .Select(x => User.Create(x.Id, x.Email, x.Password, x.FirstName, x.LastName).registerModel)
            .ToList();
        
        return users;
    }

    public async Task<Guid> Create(User user)
    {
        var userEntity = new UserEntity
        {
            Id = user.Id,
            Email = user.Email,
            Password = user.Password,
            FirstName = user.FirstName,
            LastName = user.LastName
        };
        
        await _context.Users.AddAsync(userEntity);
        await _context.SaveChangesAsync();
        
        return userEntity.Id;
    }

    public async Task<Guid> Update(Guid id, string email, string password, string firstName, string lastName)
    {
        await _context.Users.Where(x => x.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(x => x.Email, x => email)
                .SetProperty(x => x.Password, x => password)
                .SetProperty(x => x.FirstName, x => firstName)
                .SetProperty(x => x.LastName, x => lastName));
        
        return id;
    }

    public  async Task<Guid> Delete(Guid id)
    {
        await _context.Users.Where(x => x.Id == id)
            .ExecuteDeleteAsync();
        
        return id;
    }
}
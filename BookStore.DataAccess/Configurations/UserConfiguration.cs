using BookStore.Core.Models;
using BookStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DataAccess.Configurations;

public class UserConfiguration
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Email)
            .HasMaxLength(User.MAX_EMAIL_LENGTH)
            .IsRequired();

        builder.Property(x => x.Password)
            .IsRequired();
        
        builder.Property(x  => x.FirstName)
            .IsRequired();
        
        builder.Property(x => x.LastName)
            .IsRequired();
    }
}
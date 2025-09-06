using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public sealed class AdminDbContext : IdentityDbContext<User, UserRole, Guid>
{
    public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options) { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.LogTo(Console.WriteLine);
    }
}
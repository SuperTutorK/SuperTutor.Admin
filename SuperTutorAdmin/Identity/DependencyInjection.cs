using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Identity;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        services
            .AddAuthentication();
        
        services
            .AddIdentityCore<User>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
            })
            .AddEntityFrameworkStores<AdminDbContext>()
            .AddDefaultTokenProviders();
        
        return services;
    }
}
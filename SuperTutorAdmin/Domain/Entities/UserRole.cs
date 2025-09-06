using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class UserRole : IdentityRole<Guid>
{
    public UserRoleType UserRoleType {get; init;}
}
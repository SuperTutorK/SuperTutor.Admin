using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; }
    public string LastName { get; }
    public virtual UserRoleType UserRoleType { get; }
}
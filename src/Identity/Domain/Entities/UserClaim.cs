using Identity.Domain.Enums;

namespace Identity.Domain.Entities;

public class UserClaim : Base
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public ClaimType ClaimType { get; set; }
    public string ClaimValue { get; set; } = null!;
}

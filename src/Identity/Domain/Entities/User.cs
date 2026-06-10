using Identity.Domain.Enums;
using Identity.Domain.ValueObjects;

namespace Identity.Domain.Entities
{
     /// <summary>
    /// Represents a user in the system. A user can have multiple roles and claims that determine their permissions and access levels.
    /// </summary>
    public class User : Base
    {
        public string UserName { get; set; } = null!;
        public Email Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
        public UserStatus Status { get; set; } = UserStatus.Active;
        public DateTimeOffset? LockoutEnd { get; set; }
        public int AccessFailedCount { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = [];
        public ICollection<UserClaim> UserClaims { get; set; } = [];
    }
}
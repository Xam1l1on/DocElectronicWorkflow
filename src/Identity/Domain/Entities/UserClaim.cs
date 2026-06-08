using Identity.Domain.Enums;

namespace Identity.Domain.Entities;
/// <summary>
/// Represents a claim that a user possesses. A claim is a statement about a user that can be used for authorization decisions.
/// </summary>
public class UserClaim : Base
{
    /// <summary>
    /// The ID of the user that this claim belongs to.
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// The user that this claim belongs to.
    /// </summary>
    public User User { get; set; } = null!;
    /// <summary>
    /// The type of the claim. This is an enum that represents the different types of claims that a user can have.
    /// </summary>
    public ClaimType ClaimType { get; set; }
    /// <summary>
    /// The value of the claim. This is a string that represents the value of the claim. For example, if the claim type is "Role", the claim value could be "Admin" or "User".
    /// </summary>
    public string ClaimValue { get; set; } = null!;
}

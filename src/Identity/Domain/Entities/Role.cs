namespace Identity.Domain.Entities;

public class Role : Base
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public ICollection<UserRole> UserRoles { get; set; } = [];
    public ICollection<RolePermission> RolePermissions { get; set; } = [];
}

namespace Identity.Domain.Entities;

public class Permission : Base
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? Category { get; set; }
    public ICollection<RolePermission> RolePermissions { get; set; } = [];
}

using System.ComponentModel.DataAnnotations;
namespace Identity.Domain.Entities
{
    public abstract class Base
    {
        [Key]
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
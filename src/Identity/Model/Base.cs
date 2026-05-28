using System.ComponentModel.DataAnnotations;
namespace Identity.Model
{
    public abstract class Base
    {
        [Key]
        [Required (ErrorMessage = "Id is required.")]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public User? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public User? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
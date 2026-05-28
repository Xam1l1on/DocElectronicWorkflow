using System;
using System.ComponentModel.DataAnnotations;

namespace Identity.Model
{
    public class Role : Base
    {
        public Role()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            Name = string.Empty;
        }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
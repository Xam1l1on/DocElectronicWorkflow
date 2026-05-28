using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Identity.Model
{
    public class User : Base
    {
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [EmailAddress]
        [StringLength(256)]
        public string? Email { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        [StringLength(100)]
        public string? FirstName { get; set; }

        [StringLength(100)]
        public string? LastName { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool LockoutEnabled { get; set; }

        public Role? Roles { get; set; }

        public string FullName => string.Join(" ", new[] { FirstName, LastName }.Where(s => !string.IsNullOrWhiteSpace(s)));
    }
}

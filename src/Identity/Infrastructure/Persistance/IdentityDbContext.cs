using Microsoft.EntityFrameworkCore;

using Identity.Domain.Entities;

namespace Identity.Infrastructure.Persistance
{
    public class IdentityDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
            
        }
    }
}

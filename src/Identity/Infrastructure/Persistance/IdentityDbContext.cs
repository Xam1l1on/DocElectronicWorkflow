using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DocumentPlatform.DocElectronicWorkflow.Identity.Infrastructure.Persistance
{
    public class IdentityDbContext : DbContext
    {
        internal DbSet<IdentityUser> Users { get; init; }
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

using Identity.Domain.Entities;

namespace Identity.Infrastructure.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IdentityDbContext _context;

        public UserRepository(IdentityDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(User userEntity)
        {
            await _context.Users.AddAsync(userEntity);
        }

        public async Task Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetListAsync(bool includeDeleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersByRoleNameAsync(string roleName, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersByUserNameAsync(string userName, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserWithRolesAndClaimsAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
    
}
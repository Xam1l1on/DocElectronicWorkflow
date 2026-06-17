using Identity.Domain.Entities;
namespace Identity.Infrastructure.Persistance.Repositories
{
    public interface IUserRepository: IBaseRepository<User>
    {
        public Task<IEnumerable<User>> GetUsersByUserNameAsync(string userName, CancellationToken cancellationToken = default);
        public Task<IEnumerable<User>> GetUsersByEmailAsync(string email, CancellationToken cancellationToken = default);
        public Task<User> GetUserWithRolesAndClaimsAsync(Guid id, CancellationToken cancellationToken = default);
        public Task<IEnumerable<User>> GetUsersByRoleNameAsync(string roleName, CancellationToken cancellationToken = default);
    }
}
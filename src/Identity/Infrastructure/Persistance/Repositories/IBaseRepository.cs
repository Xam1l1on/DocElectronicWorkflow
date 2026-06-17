using Identity.Domain.Entities;
using System.Linq.Expressions;
namespace Identity.Infrastructure.Persistance.Repositories
{
    public interface IBaseRepository<T> where T: Base
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task Delete(T entity);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetListAsync(bool includeDeleted = false);
    }
}
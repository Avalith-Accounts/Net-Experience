using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Command
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}

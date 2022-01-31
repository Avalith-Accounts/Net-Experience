using Net.Experience.Domain.Interfaces.Command;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Experience.Persistance.Sql.Command
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly NetExperienceDbContext _context;
        public BaseRepository(NetExperienceDbContext context)
        {
            _context = context;
        }
        public async Task<T> Add(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            Complete();

            return result.Entity;
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
           await  _context.Set<T>().AddRangeAsync(entities);
           Complete();
        }

        public void Remove(T entity)
        {
             _context.Set<T>().Remove(entity);
            Complete();
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            Complete();
        }

        public void Update(T entity) 
        {
            _context.Set<T>().Update(entity);
            Complete();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}

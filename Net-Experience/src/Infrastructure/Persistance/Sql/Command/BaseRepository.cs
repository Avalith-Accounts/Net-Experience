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
            await Complete();

            return result.Entity;
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
           await  _context.Set<T>().AddRangeAsync(entities);
            await Complete();
        }

        public async Task Remove(T entity)
        {
             _context.Set<T>().Remove(entity);
             await Complete();
        }
        public async Task RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            await Complete();
        }

        public async Task Update(T entity) 
        {
            _context.Set<T>().Update(entity);
            await Complete();
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

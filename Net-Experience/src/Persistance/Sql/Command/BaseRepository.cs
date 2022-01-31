using Net.Experience.Domain.Interfaces.Command;
using System.Collections.Generic;

namespace Net.Experience.Persistance.Sql.Command
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly NetExperienceDbContext _context;
        public BaseRepository(NetExperienceDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity) 
        {
            _context.Set<T>().Update(entity);
        }
    }
}

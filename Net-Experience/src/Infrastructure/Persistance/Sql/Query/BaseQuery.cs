using Net.Experience.Domain.Interfaces.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Net.Experience.Persistance.Sql.Query
{
    public class BaseQuery<T> : IBaseQuery<T> where T : class
    {
        protected readonly NetExperienceDbContext _context;
        public BaseQuery(NetExperienceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public async Task<T> GetById(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetById(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}

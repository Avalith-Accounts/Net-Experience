using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Query
{
    public interface IBaseQuery<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<T> GetById(string id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    }
}

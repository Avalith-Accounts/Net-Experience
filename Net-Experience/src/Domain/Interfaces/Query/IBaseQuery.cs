using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Net.Experience.Domain.Interfaces.Query
{
    public interface IBaseQuery<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Walkabouts.Repository
{
    public interface IWalkaboutRepository<T>
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T GetById(int entityId);
        int Add(T entity);
        int Update(T entity);

        //void SaveError(DbError error);

    }
}

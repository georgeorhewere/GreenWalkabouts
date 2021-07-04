using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Walkabouts.Repository
{
    public interface IWalkaboutRepository<T>
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate, int page = 1, int pageSize = 10);
        IQueryable<T> GetAll(int page = 1,int pageSize = 10);
        T GetById(long entityId);
        int Add(T entity);
        int Update(T entity);

        //void SaveError(DbError error);

    }
}

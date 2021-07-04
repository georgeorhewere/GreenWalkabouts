using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Repository.Context;

namespace Walkabouts.Repository
{
    public class ProductRepository : IWalkaboutRepository<Product>
    {
        private WalkaboutsDbContext context;
        public ProductRepository(WalkaboutsDbContext _context)
        {
            context = _context;
        }

        public int Add(Product entity)
        {
            throw new NotImplementedException();
        }  

        public IEnumerable<Product> Get(Expression<Func<Product, bool>> predicate, int page = 1, int pageSize = 10)
        {
            int skip = (page - 1) * pageSize;
            return context.Products.Where(predicate).Skip(skip).Take(pageSize);
        }

        public IQueryable<Product> GetAll(int page = 1, int pageSize = 10)
        {
            int skip = (page - 1) * pageSize;
            return context.Products.Skip(skip).Take(pageSize);
        }

        public Product GetById(long entityId)
        {
            return context.Products.Find(entityId);
        }

        public int Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

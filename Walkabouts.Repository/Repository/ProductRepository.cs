using System;
using System.Collections.Generic;
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

        public IEnumerable<Product> Get(Expression<Func<Product, bool>> predicate)
        {
            return context.Products.AsQueryable();
        }

        public Product GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public int Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

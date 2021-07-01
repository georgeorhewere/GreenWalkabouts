using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Repository.Context;
using Walkabouts.Services.DTO;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.Services.Implementations
{
    public class CatalogService : BaseService,ICatalogService
    {
        
        public CatalogService(WalkaboutsDbContext _context, IMapper _mapper) :base(_context,_mapper)
        {
            
        }

      

        public IEnumerable<CatalogItemDTO> GetAll(Expression<Func<Product, bool>> predicate)
        {
            return context.Products.Where(predicate).Select(x => new CatalogItemDTO { ProductName = x.ProductName });
        }

        public IEnumerable<CatalogItemDTO> GetCatalog()
        {
            return context.Products.Select(x => mapper.Map<CatalogItemDTO>(x));
        }

        public CatalogItemDTO GetCatalogItem(long Id)
        {
            return context.Products.Where(x => x.Id == Id)
                                   .Select(x => mapper.Map<CatalogItemDTO>(x))
                                   .FirstOrDefault();
        }
    }
}

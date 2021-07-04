using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Repository;
using Walkabouts.Repository.Context;
using Walkabouts.Services.DTO;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.Services.Implementations
{
    public class CatalogService : ICatalogService
    {
        protected readonly IWalkaboutRepository<Product> productRepository;
        protected readonly IMapper mapper;
        public CatalogService(IWalkaboutRepository<Product> _productRepository, IMapper _mapper)
        {
            productRepository = _productRepository;
            mapper = _mapper;
        }

      

        public IEnumerable<CatalogItemDTO> GetAll(Expression<Func<Product, bool>> predicate)
        {
            return productRepository.Get(predicate).Select(x => mapper.Map<CatalogItemDTO>(x));
        }

        public IEnumerable<CatalogItemDTO> GetCatalog()
        {
            return productRepository.GetAll().Select(x => mapper.Map<CatalogItemDTO>(x));
            //return context.Products.Select(x => mapper.Map<CatalogItemDTO>(x));
        }

        public CatalogItemDTO GetCatalogItem(long Id)
        {
            return mapper.Map<CatalogItemDTO>(productRepository.GetById(Id));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Services.DTO;

namespace Walkabouts.Services.Interfaces
{
    public interface ICatalogService
    {
        IEnumerable<CatalogItemDTO> GetAll(Expression<Func<Product, bool>> predicate);
        IEnumerable<CatalogItemDTO> GetCatalog();
        CatalogItemDTO GetCatalogItem(long Id);
    }
}

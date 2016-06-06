using System;
using System.Collections;
using System.Collections.Generic;
using HandMadeShop.Data.Infrastructure;
using HandMadeShop.Model.Models;
using System.Linq;

namespace HandMadeShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    internal class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x=> x.Alias == alias);
        }
    }
}
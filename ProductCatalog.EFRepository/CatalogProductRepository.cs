using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Products;
using ProductCatalog.Repository;

namespace ProductCatalog.EFRepository
{
    public class CatalogProductRepository : GenericRepository<Product>, ICatalogProductRepository
    {
        private readonly CatalogDBContext context;
        public CatalogProductRepository(CatalogDBContext context) : base(context)
        {
            this.context = context;
        }

    }
}

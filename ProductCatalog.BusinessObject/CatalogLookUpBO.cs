using ProductCatalog.Domain.Products;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public class CatalogLookUpBO : ICatalogLookUpBO
    {
        private readonly ICatalogLookUpRepository catalogLookUpRepository;

        public CatalogLookUpBO(ICatalogLookUpRepository catalogLookUpRepository)
        {
            this.catalogLookUpRepository = catalogLookUpRepository;
        }
        
        public async Task<LookUp> Add(LookUp item)
        {
            
            return await catalogLookUpRepository.Add(item);
            
        }

        public async Task<IEnumerable<LookUp>> GetLookUpItems()
        {
            return await catalogLookUpRepository.GetAll();
        }
    }
}

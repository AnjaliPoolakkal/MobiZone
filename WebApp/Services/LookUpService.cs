using Microsoft.Extensions.Configuration;
using ProductCatalog.Domain.Products;
using System;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class LookUpService : GenericService<LookUp>,ILookUpService
    {
       
        IConfiguration _config;
        public LookUpService(IConfiguration config):base(config)
        {
            _config = config;
        }

        public Task<bool> AddAsync(Task item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddLookUpAsync(LookUp item)
        {
            return await AddAsync( item);
        }

        
    }
}

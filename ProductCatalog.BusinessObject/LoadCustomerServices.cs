using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.EFRepository;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public class LoadCustomerServices
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<ICatalogLookUpRepository, CatalogLookUpRepository>();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Models
{
    public class productModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
    }
}

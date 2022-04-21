using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.Models;
using ProductCatalog.API.ViewModel;
using System.Collections.Generic;

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<productModel> Get()
        {
            ProductModel pr = new ProductModel();
            return pr.findAll();
        }
        
    }
}

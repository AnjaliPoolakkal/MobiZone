using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessObject;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogLookUpController : ControllerBase
    {
        

        private readonly ICatalogLookUpBO catalogLookUpBO;

        public CatalogLookUpController(ICatalogLookUpBO catalogLookUpBO)
        {
            this.catalogLookUpBO = catalogLookUpBO;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LookUp>>> GetLookUpItems()
        {
            return Ok(await catalogLookUpBO.GetLookUpItems());
        }
        [HttpPost]
        public async Task<ActionResult<LookUp>> 
            post(LookUp lookUp)
        {
            
                var item = await catalogLookUpBO.Add(lookUp);
                if (item.name == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction("GetLookUpItems", new { id = lookUp.Id }, item);
                }
           
        }
    }
}

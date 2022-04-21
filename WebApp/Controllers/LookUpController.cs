using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class LookUpController : Controller
    {
        private readonly ILookUpService catalogService;
        private readonly INotyfService _notyf;
        IConfiguration Configuration { get; }
        public LookUpController(ILookUpService catalogService, INotyfService notyf, IConfiguration configuration)
        {
            this.catalogService = catalogService;
            this._notyf = notyf;
            this.Configuration = configuration;
        }
        public async Task<IActionResult> Index(int id)
        {
            var items = await catalogService.GetLookUpItemsAsync();
            return View(items);
        }
        [HttpGet]
        public async Task<IActionResult> LookUpData()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LookUpData(LookUp lookUp)
        {
           
                bool result = await catalogService.AddAsync(lookUp);
                if (result)
                {

                    _notyf.Success(Configuration.GetSection("LookUp")["LookUpAdded"].ToString());
                }
                else
                {
                    _notyf.Error(Configuration.GetSection("LookUp")["LookUpAddedError"].ToString());
                }
                ModelState.Clear();
        
            
            return View();
            
        }
    }
}

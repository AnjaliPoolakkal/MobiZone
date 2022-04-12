using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProductCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IConfiguration Configuration { get; }
        public ProductController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            
            IEnumerable<productModel> product = null;
            using (var client = new System.Net.Http.HttpClient())
            {
                string url = Configuration.GetSection("Development")["baseurl"].ToString()+"api/product";
                Uri uri = new Uri(url);
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<productModel>>();
                    readJob.Wait();
                    product = readJob.Result;
                    List<string> Name = new List<string>();
                    foreach (productModel name in product)
                    {
                        Name.Add(name.Name);
                    }
                    ViewBag.list = Name;
                }

            }   
       
            return View(product);
        }
       
    }
}

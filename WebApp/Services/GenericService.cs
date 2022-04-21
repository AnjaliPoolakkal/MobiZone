using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private string catalogServiceUrl;
        public GenericService(IConfiguration config)
        {
            catalogServiceUrl = config["CatalogUrl"];
        }
        public async Task<bool> AddAsync(T item)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                string json = JsonConvert.SerializeObject(item);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(catalogServiceUrl + "/api/CatalogLookUp", content);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<IEnumerable<T>> GetLookUpItemsAsync()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(catalogServiceUrl + "/api/CatalogLookUp");
                var dataString = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(dataString);
            }
        }
    }


}

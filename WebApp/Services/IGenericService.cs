using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetLookUpItemsAsync();
        
        Task<bool> AddAsync(T item);
    }
}

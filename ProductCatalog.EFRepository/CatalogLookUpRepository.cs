using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Products;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class CatalogLookUpRepository : GenericRepository<LookUp>, ICatalogLookUpRepository
    {
        private readonly CatalogDBContext _context;

        public CatalogLookUpRepository(CatalogDBContext _context):base(_context)
        {
            this._context = _context;
        }


        public async Task<LookUp> Add(LookUp item)
        {
            _context.LookUp.Add(item);
          
            await _context.SaveChangesAsync();
            return item;
        }

        public async override Task<IEnumerable<LookUp>> GetAll()
        {
            return await _context.LookUp.ToListAsync();
        }
        







    }
}

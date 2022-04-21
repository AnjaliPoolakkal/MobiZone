using Microsoft.EntityFrameworkCore;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class GenericRepository<T> : IGenericService<T> where T : class
    {
        private readonly DbContext context;
        DbSet<T> dbSet;
        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public async virtual Task<T> Add(T item)
        {
            dbSet.Add(item);
            await context.SaveChangesAsync();
            return item;
        }

        public async virtual Task Delete(int id)
        {
            T entity = await dbSet.FindAsync(id);
            dbSet.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async virtual Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async virtual Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async virtual Task Update(T item)
        {
            context.Entry<T>(item).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
       
    }
}

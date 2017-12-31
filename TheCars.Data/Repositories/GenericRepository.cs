using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCars.Data.Repositories
{
    public class GenericRepository<T> where T : class
    {
        protected CarsContext context;
        protected DbSet<T> dbSet;

        public GenericRepository()
        {
            context = new CarsContext();
            dbSet = context.Set<T>();
        }

        public async virtual Task<IList<T>> GetAll()
        {
            return dbSet.ToList();
        }

        public async virtual Task<T> GetById(object id)
        {
            return await dbSet.FindAsync(id);
        }



        public async virtual Task<int> Insert(T entity)
        {
            dbSet.Add(entity);
            return await context.SaveChangesAsync();
        }

        public async virtual Task<int> DeleteAsync(object id)
        {
            var entity = dbSet.FindAsync(id);
            return await DeleteAsync(entity);
        }

        public async virtual Task<int> Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return await context.SaveChangesAsync();
        }

        public async virtual Task<int> DeleteAsync(T entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            return await context.SaveChangesAsync();
        }
    }
}

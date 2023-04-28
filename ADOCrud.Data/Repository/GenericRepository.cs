using ADOCrud.Data.DbContexts;
using ADOCrud.Data.IRepository;
using ADOCrud.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        private readonly AppDbContext dbContext;
        private DbSet<T> dbSet;

        public GenericRepository()
        {
            this.dbContext = new AppDbContext();
            this.dbSet = dbContext.Set<T>();
        }

        public async ValueTask<T> CreateAsync(T entity)
        {
            var create = (await dbContext.AddAsync(entity)).Entity;

            await dbContext.SaveChangesAsync();

            return create;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var deletedEntity = await GetAsync(u => u.Id == id);

            if (deletedEntity == null)
                return false;

            dbSet.Remove(deletedEntity);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true)
        {
            //var entity = dbSet.Where(expression);

            var entity = expression is null ? dbSet : dbSet.Where(expression);

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    if (!string.IsNullOrEmpty(include))
                        dbSet.Include(include);
                }
            }
            if (!isTracking)
            {
                dbSet.AsNoTracking();
            }
            return entity;
        }

        public async ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true)
            => await GetAll(expression, includes, false).FirstOrDefaultAsync();

        //public T UpdateAsync(T entity)
        //    => dbSet.Update(entity).Entity;

        public async ValueTask<T> UpdateAsync(T entity)
        {
            var update = (dbContext.Update(entity)).Entity;
            await dbContext.SaveChangesAsync();
            return update;
        }
    }
}

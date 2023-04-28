using ADOCrud.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Data.IRepository
{
    public interface IGenericRepository<T> where T : Auditable
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true);
        ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true);
        ValueTask<T> CreateAsync(T entity);
        ValueTask<bool> DeleteAsync(int id);

        //T UpdateAsync(T entity);

        ValueTask<T> UpdateAsync(T entity);
    }
}

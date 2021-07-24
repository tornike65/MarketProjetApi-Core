using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Abstract.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IQueryable<T>> Query();
        Task<List<T>> GetAllAsync();
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(object id);
        Task AddAsync(T obj);
        Task UpdateAsync(T obj);
        Task DeleteAsync(object id);
        Task<int> SaveAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Abstract.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DbContext _context;
        private DbSet<T> _dbset;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public async Task AddAsync(T obj)
        {
            await _dbset.AddAsync(obj);
            await SaveAsync();
        }

        public async Task DeleteAsync(object id)
        {
            _dbset.Remove(await GetByIdAsync(id));
            await SaveAsync();
        }

        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.AsQueryable().Where(predicate).AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbset.AsQueryable().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task<IQueryable<T>> Query()
        {
            return await Task.Run(() => _dbset.AsQueryable());
        }

        public async Task<int> SaveAsync()
        {
          return await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T obj)
        {
            _dbset.Update(obj).State = EntityState.Modified;
            await SaveAsync();
        }
    }
}

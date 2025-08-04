using BaseClass_dll.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Infrastructure
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private ApplicationDbContext _context;
        private DbSet<T> _dbset;
        public BaseRepo(ApplicationDbContext context
        )
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await _dbset.AddAsync(entity);
        }

        public void Add(List<T> entity)
        {
            _dbset.AddRangeAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public async void DeletebyID(Expression<Func<T, bool>> predicate)
        {
            var entity = await _dbset.Where(predicate).FirstOrDefaultAsync();
            if (entity != null)
            {
                _dbset.Remove(entity);
            }
        }

        public void DeleteRange(IEnumerable<T> entitylist)
        {
            _dbset.RemoveRange(entitylist);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? predicate, string? includeProperties)
        {
            IQueryable<T> query = _dbset;
            try
            {
                if (predicate != null)
                {
                    query = query.Where(predicate);
                }
                if (includeProperties != null)
                {
                    foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(item);
                    }
                }
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                return await query.ToListAsync();
            }
        }

        public async Task<T> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task<T> GetT(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.Where(predicate).FirstOrDefaultAsync();
        }

        public void Update(T entity)
        {
            _dbset.Update(entity);
        }
    }
}

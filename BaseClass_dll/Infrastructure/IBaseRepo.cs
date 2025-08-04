using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Infrastructure
{
    public interface IBaseRepo<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? predicate, string? includeProperties);
        //IEnumerable<T> GetAllbyParent(Expression<Func<T, bool>> predicate);
        Task<T> GetT(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        void Add(List<T> entity);
        void Delete(T entity);
        void DeletebyID(Expression<Func<T, bool>> predicate);
        void DeleteRange(IEnumerable<T> entitylist);
        void Update(T entity);
    }
}

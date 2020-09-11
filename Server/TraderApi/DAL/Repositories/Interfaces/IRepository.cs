using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        void Remove(TEntity entity);
        int Count();
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}

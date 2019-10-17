using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryBaseAsync<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetSingleOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
                
        Task CreateAsync(TEntity entity);

        Task UpdateAsync(TEntity dbEntity);

        Task DeleteAsync(TEntity entity);
    }
}

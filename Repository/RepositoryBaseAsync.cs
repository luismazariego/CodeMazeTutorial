using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryBaseAsync<T> : RepositoryBase<T>, IRepositoryBaseAsync<T> where T : class
    {
        public RepositoryBaseAsync(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }

        public async Task CreateAsync(T entity)
        {
            Create(entity);
            await SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            Delete(entity);
            await SaveAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await FindAll().ToListAsync();              
        }

        public async Task<T> GetSingleOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await FindByCondition(expression).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            //dbEntity.Map(entity);
            Update(entity);
            await SaveAsync();
        }
    }
}

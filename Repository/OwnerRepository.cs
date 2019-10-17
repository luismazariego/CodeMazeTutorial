using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class OwnerRepository : RepositoryBaseAsync<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<Owner> GetOwnerByIdAsync(Guid ownerId)
        {
            return await GetSingleOrDefaultAsync(x => x.OwnerId == ownerId);
        }

        
    }
}

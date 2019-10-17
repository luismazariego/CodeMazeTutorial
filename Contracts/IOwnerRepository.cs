using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IOwnerRepository : IRepositoryBaseAsync<Owner>
    {
        //Task<OwnerExtended> GetOwnerWithDetailsAsync(Guid ownerId);
        Task<Owner> GetOwnerByIdAsync(Guid ownerId);

        //Task UpdateOwnerAsync(Owner dbOwner, Owner owner);
    }
}

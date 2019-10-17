using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Contracts;
using Entities;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}

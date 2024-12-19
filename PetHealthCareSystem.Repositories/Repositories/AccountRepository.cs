using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public Task<bool> AddAccountAsync(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DelAccountAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DelAccountAsync(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<List<Account>> GetAllAccountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAccountAsync(Account account)
        {
            throw new NotImplementedException();
        }
    }
}

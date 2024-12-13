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
        public bool AddAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public bool DelAccount(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<List<Account>> GetAllAccount()
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}

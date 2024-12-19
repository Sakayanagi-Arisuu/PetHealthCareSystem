using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetAllAccountAsync();
        Task <bool> DelAccountAsync(int id);
        Task <bool> DelAccountAsync(Account account);
        Task <bool> AddAccountAsync(Account account);
        Task <bool> UpdateAccountAsync(Account account);
    }
}

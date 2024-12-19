using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using PetHealthCareSystem.Repositories.Entities;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IAccountService
    {
        Task<List<Account>> GetAllAccountAsync();
        Task<bool> DelAccountAsync(int id);
        Task<bool> DelAccountAsync(Account account);
        Task<bool> AddAccountAsync(Account account);
        Task<bool> UpdateAccountAsync(Account account);
    }
}

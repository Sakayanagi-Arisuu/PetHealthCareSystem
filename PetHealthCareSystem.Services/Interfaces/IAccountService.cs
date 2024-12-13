using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetAllAccount();
        Boolean DelAccount(int id);
        Boolean DelAccount(Account account);
        Boolean AddAccount(Account account);
        Boolean UpdateAccount(Account account);
    }
}

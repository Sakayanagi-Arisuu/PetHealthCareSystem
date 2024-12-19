using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using PetHealthCareSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;
        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAccountAsync(Account account)
        {
            return await _repository.AddAccountAsync(account);
        }

        public async Task<bool> DelAccountAsync(int id)
        {
            return await _repository.DelAccountAsync(id);
        }

        public async Task<bool> DelAccountAsync(Account account)
        {
            return await _repository.DelAccountAsync(account);
        }

        public async Task<List<Account>> GetAllAccountAsync()
        {
            return await _repository.GetAllAccountAsync();
        }

        public async Task<bool> UpdateAccountAsync(Account account)
        {
            return await _repository.UpdateAccountAsync(account);
        }
    }
}

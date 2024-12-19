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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddUserAsync(User user)
        {
            return await _repository.AddUserAsync(user);
        }

        public async Task<bool> DelUserAsync(int id)
        {
            return await (_repository.DelUserAsync(id));
        }

        public async Task<bool> DelUserAsync(User user)
        {
            return await _repository.DelUserAsync(user);
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await _repository.GetAllUserAsync();
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            return await _repository.UpdateUserAsync(user);
        }
    }
}

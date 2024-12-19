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
    public class HealProcessService : IHealProcessService
    {
        private readonly IHealProcessRepository _repository;
        public HealProcessService(IHealProcessRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddHealProcessAsync(HealProcess healProcess)
        {
            return await _repository.AddHealProcessAsync(healProcess);
        }

        public async Task<bool> DelHealProcessAsync(HealProcess healProcess)
        {
            return await _repository.DelHealProcessAsync(healProcess);
        }

        public async Task<bool> DelHealProcessAsync(int id)
        {
            return await _repository.DelHealProcessAsync((int)id);
        }

        public async Task<List<HealProcess>> GetAllHealProcessAsync()
        {
            return await _repository.GetAllHealProcessAsync();
        }

        public async Task<bool> UpdateHealProcessAsync(HealProcess healProcess)
        {
            return await _repository.UpdateHealProcessAsync(healProcess);
        }
    }
}

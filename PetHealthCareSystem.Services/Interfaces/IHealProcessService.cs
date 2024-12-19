using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IHealProcessService
    {
        Task<List<HealProcess>> GetAllHealProcessAsync();
        Task<bool> DelHealProcessAsync(int id);
        Task<bool> DelHealProcessAsync(HealProcess healProcess);
        Task<bool> AddHealProcessAsync(HealProcess healProcess);
        Task<bool> UpdateHealProcessAsync(HealProcess healProcess);
    }
}

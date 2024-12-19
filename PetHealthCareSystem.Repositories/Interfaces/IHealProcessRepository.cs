using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IHealProcessRepository
    {
        Task<List<HealProcess>> GetAllHealProcessAsync();
        Task<bool> DelHealProcessAsync(int id);
        Task<bool> DelHealProcessAsync (HealProcess healProcess);
        Task<bool> AddHealProcessAsync (HealProcess healProcess);
        Task<bool> UpdateHealProcessAsync (HealProcess healProcess);
    }
}

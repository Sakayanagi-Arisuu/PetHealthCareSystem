using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IHealProcessRepository
    {
        Task<List<HealProcess>> GetAllHealProcess();
        Boolean DelHealProcessbyId(int id);
        Boolean DelHealProcess(HealProcess healProcess);
        Boolean AddHealProcess(HealProcess healProcess);
        Boolean UpdateHealProcess(HealProcess healProcess);
    }
}

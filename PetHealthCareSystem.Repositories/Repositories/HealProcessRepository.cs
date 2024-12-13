using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class HealProcessRepository : IHealProcessRepository
    {
        public bool AddHealProcess(HealProcess healProcess)
        {
            throw new NotImplementedException();
        }

        public bool DelHealProcess(HealProcess healProcess)
        {
            throw new NotImplementedException();
        }

        public bool DelHealProcessbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<HealProcess>> GetAllHealProcess()
        {
            throw new NotImplementedException();
        }

        public bool UpdateHealProcess(HealProcess healProcess)
        {
            throw new NotImplementedException();
        }
    }
}

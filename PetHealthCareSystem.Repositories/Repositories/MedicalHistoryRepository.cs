using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class MedicalHistoryRepository : IMedicalHistoryRepository
    {
        public bool AddMedicalHistory(MedicalHistory history)
        {
            throw new NotImplementedException();
        }

        public bool DelMedicalHistory(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelMedicalHistory(MedicalHistory history)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicalHistory>> GetAllMedicalHistory()
        {
            throw new NotImplementedException();
        }

        public bool UpdateMedicalHistory(MedicalHistory history)
        {
            throw new NotImplementedException();
        }
    }
}

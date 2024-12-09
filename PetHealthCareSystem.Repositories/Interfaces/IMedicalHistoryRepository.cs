using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IMedicalHistoryRepository
    {
        Task<List<MedicalHistory>> GetAllMedicalHistory();
        Boolean DelMedicalHistory (int id);
        Boolean DelMedicalHistory (MedicalHistory history);
        Boolean AddMedicalHistory (MedicalHistory history);
        Boolean UpdateMedicalHistory (MedicalHistory history);
    }
}

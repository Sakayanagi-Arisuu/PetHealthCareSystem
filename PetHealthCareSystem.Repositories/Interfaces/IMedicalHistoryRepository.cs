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
        Task<List<MedicalHistory>> GetAllMedicalHistoryAsync();
        Task<bool> DelMedicalHistoryAsync (int id);
        Task<bool> DelMedicalHistoryAsync (MedicalHistory history);
        Task<bool> AddMedicalHistoryAsync (MedicalHistory history);
        Task<bool> UpdateMedicalHistoryAsync (MedicalHistory history);
    }
}

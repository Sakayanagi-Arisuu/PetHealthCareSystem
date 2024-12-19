using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IMedicalHistoryService
    {
        Task<List<MedicalHistory>> GetAllMedicalHistoryAsync();
        Task<bool> DelMedicalHistoryAsync(int id);
        Task<bool> DelMedicalHistoryAsync(MedicalHistory history);
        Task<bool> AddMedicalHistoryAsync(MedicalHistory history);
        Task<bool> UpdateMedicalHistoryAsync(MedicalHistory history);
    }
}

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
    public class MedicalHistoryService : IMedicalHistoryService
    {
        private readonly IMedicalHistoryRepository _repository;
        public MedicalHistoryService(IMedicalHistoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddMedicalHistoryAsync(MedicalHistory history)
        {
            return await _repository.AddMedicalHistoryAsync(history);
        }

        public async Task<bool> DelMedicalHistoryAsync(int id)
        {
            return await _repository.DelMedicalHistoryAsync(id);
        }

        public async Task<bool> DelMedicalHistoryAsync(MedicalHistory history)
        {
            return await (_repository.DelMedicalHistoryAsync(history));
        }

        public async Task<List<MedicalHistory>> GetAllMedicalHistoryAsync()
        {
            return await _repository.GetAllMedicalHistoryAsync();
        }

        public async Task<bool> UpdateMedicalHistoryAsync(MedicalHistory history)
        {
            return await _repository.UpdateMedicalHistoryAsync(history);
        }
    }
}

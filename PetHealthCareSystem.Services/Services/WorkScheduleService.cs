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
    public class WorkScheduleService : IWorkScheduleService
    {
        private readonly IWorkScheduleRepository _repository;
        public WorkScheduleService(IWorkScheduleRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddWorkScheduleAsync(WorkSchedule workSchedule)
        {
            return await _repository.AddWorkScheduleAsync(workSchedule);
        }

        public async Task<bool> DeleteWorkScheduleAsync(WorkSchedule workSchedule)
        {
            return await _repository.DeleteWorkScheduleAsync(workSchedule);
        }

        public async Task<bool> DelWorkScheduleAsync(int id)
        {
            return await _repository.DelWorkScheduleAsync(id);
        }

        public async Task<List<WorkSchedule>> GetAllWorkScheduleAsync()
        {
            return await _repository.GetAllWorkScheduleAsync();
        }

        public async Task<bool> UpdateWorkScheduleAsync(WorkSchedule workSchedule)
        {
            return await _repository.UpdateWorkScheduleAsync(workSchedule);
        }
    }
}

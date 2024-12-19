using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IWorkScheduleRepository
    {
        Task<List<WorkSchedule>> GetAllWorkScheduleAsync();
        Task<bool> DelWorkScheduleAsync(int id);
        Task<bool> DeleteWorkScheduleAsync(WorkSchedule workSchedule);
        Task<bool> UpdateWorkScheduleAsync(WorkSchedule workSchedule);
        Task<bool> AddWorkScheduleAsync (WorkSchedule workSchedule);
    }
}

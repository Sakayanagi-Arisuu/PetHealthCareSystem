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
        Task<List<WorkSchedule>> GetAllWorkSchedule();
        Boolean DelWorkSchedule(int id);
        Boolean DeleteWorkSchedule(WorkSchedule workSchedule);
        Boolean UpdateWorkSchedule(WorkSchedule workSchedule);
        Boolean AddWorkSchedule (WorkSchedule workSchedule);
    }
}

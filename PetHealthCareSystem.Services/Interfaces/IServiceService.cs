using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllServiceAsync();
        Task<bool> DelServiceAsync(int id);
        Task<bool> DelServiceAsync(Service service);
        Task<bool> AddServiceAsync(Service service);
        Task<bool> UpdateServiceAsync(Service service);
    }
}

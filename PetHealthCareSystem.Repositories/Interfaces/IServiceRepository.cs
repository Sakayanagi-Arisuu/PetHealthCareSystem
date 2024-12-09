using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IServiceRepository
    {
        Task<List<Service>> GetAllService();
        Boolean DelService(int id);
        Boolean DeleteService(Service service);
        Boolean AddService (Service service);
        Boolean UpdateService (Service service);
    }
}

using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public bool AddService(Service service)
        {
            throw new NotImplementedException();
        }

        public bool DeleteService(Service service)
        {
            throw new NotImplementedException();
        }

        public bool DelService(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Service>> GetAllService()
        {
            throw new NotImplementedException();
        }

        public bool UpdateService(Service service)
        {
            throw new NotImplementedException();
        }
    }
}

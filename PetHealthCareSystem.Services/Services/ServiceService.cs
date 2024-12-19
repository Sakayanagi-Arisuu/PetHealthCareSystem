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
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _repository;
        public ServiceService(IServiceRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddServiceAsync(Service service)
        {
            return await _repository.AddServiceAsync(service);
        }

        public async Task<bool> DelServiceAsync(Service service)
        {
            return await _repository.DelServiceAsync(service);
        }

        public async Task<bool> DelServiceAsync(int id)
        {
            return await _repository.DelServiceAsync(id);
        }

        public async Task<List<Service>> GetAllServiceAsync()
        {
            return await _repository.GetAllServiceAsync();
        }

        public async Task<bool> UpdateServiceAsync(Service service)
        {
            return await _repository.UpdateServiceAsync(service);
        }
    }
}

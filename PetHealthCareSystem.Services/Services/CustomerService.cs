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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddCustomerAsync(Customer customer)
        {
            return await _repository.AddCustomerAsync(customer);
        }

        public async Task <bool> DelCustomerAsync(int id)
        {
            return await (_repository.DelCustomerAsync(id));
        }

        public async Task<bool> DelCustomerAsync(Customer customer)
        {
            return await _repository.DelCustomerAsync (customer);
        }

        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            return await _repository.GetAllCustomerAsync();
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            return await _repository.UpdateCustomerAsync(customer);
        }
    }
}

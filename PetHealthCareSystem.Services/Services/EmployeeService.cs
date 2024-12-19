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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddEmployeeAsync(Employee employee)
        {
            return await _repository.AddEmployeeAsync(employee);
        }

        public async Task<bool> DelEmployeeAsync(int id)
        {
            return await _repository.DelEmployeeAsync(id);
        }

        public async Task<bool> DelEmployeeAsync(Employee employee)
        {
            return await _repository.DelEmployeeAsync(employee);
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await _repository.GetAllEmployeeAsync();
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            return await (_repository.UpdateEmployeeAsync(employee));
        }
    }
}

using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomerAsync();
        Task<bool> DelCustomerAsync(int id);
        Task<bool> DelCustomerAsync(Customer customer);
        Task<bool> AddCustomerAsync(Customer customer);
        Task<bool> UpdateCustomerAsync(Customer customer);
    }
}

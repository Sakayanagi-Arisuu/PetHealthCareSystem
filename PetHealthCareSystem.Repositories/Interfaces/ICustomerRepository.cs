using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomer();
        Boolean DelCustomer (int  id);
        Boolean DelCustomer (Customer customer);
        Boolean AddCustomer (Customer customer);
        Boolean UpdateCustomer (Customer customer);
    }
}

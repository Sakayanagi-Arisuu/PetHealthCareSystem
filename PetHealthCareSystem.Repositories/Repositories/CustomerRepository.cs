using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DelCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}

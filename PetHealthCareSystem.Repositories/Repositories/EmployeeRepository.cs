using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public bool AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool DelEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

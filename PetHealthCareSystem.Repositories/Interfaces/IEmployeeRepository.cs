using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployee();
        Boolean DelEmployee (int id);
        Boolean DelEmployee (Employee employee);
        Boolean AddEmployee (Employee employee);
        Boolean UpdateEmployee (Employee employee);
    }
}

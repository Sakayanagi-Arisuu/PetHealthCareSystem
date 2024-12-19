﻿using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeeAsync();
        Task<bool> DelEmployeeAsync(int id);
        Task<bool> DelEmployeeAsync (Employee employee);
        Task<bool> AddEmployeeAsync (Employee employee);
        Task<bool> UpdateEmployeeAsync(Employee employee);
    }
}

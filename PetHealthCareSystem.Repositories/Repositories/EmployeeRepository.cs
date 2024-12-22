using Microsoft.EntityFrameworkCore;
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
        private readonly PetHealthCareSystemContext _DbContext;
        public EmployeeRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddEmployeeAsync(Employee employee)
        {
            try
            {
                await _DbContext.Employees.AddAsync(employee);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelEmployeeAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.Employees.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.Employees.Remove(objDel);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Error deleting booking: {ex.Message}", ex);
            }
        }

        public async Task<bool> DelEmployeeAsync(Employee employee)
        {
            try
            {
                _DbContext.Employees.Remove(employee);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await _DbContext.Employees
                .Include(e => e.User)
                .ToListAsync();
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                var existingEmployee = await _DbContext.Employees.FindAsync(employee.EmployeeId);
                if (existingEmployee != null)
                {
                    _DbContext.Entry(existingEmployee).CurrentValues.SetValues(employee);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                Console.WriteLine($"Lỗi, không thể cập nhật: ");
                return false;
            }
        }
    }
}

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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public CustomerRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddCustomerAsync(Customer customer)
        {
            try
            {
                await _DbContext.Customers.AddAsync(customer);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelCustomerAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.Customers.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.Customers.Remove(objDel);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error deleting booking: {ex.Message}", ex);
            }
        }

        public async Task<bool> DelCustomerAsync(Customer customer)
        {
            try
            {
                _DbContext.Customers.Remove(customer);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            return await _DbContext.Customers
                .Include(c => c.User)
                .ToListAsync();
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            try
            {
                var existingCustomer = await _DbContext.Customers.FindAsync(customer.CustomerId);
                if (existingCustomer != null)
                {
                    _DbContext.Entry(existingCustomer).CurrentValues.SetValues(customer);
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

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
    public class HealProcessRepository : IHealProcessRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public HealProcessRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddHealProcessAsync(HealProcess healProcess)
        {
            try
            {
                await _DbContext.HealProcesses.AddAsync(healProcess);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelHealProcessAsync(HealProcess healProcess)
        {
            try
            {
                _DbContext.HealProcesses.Remove(healProcess);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> DelHealProcessAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.HealProcesses.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.HealProcesses.Remove(objDel);
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

        public async Task<List<HealProcess>> GetAllHealProcessAsync()
        {
            return await _DbContext.HealProcesses
                .Include(h => h.Pet)
                .Include(h => h.Veterinarian)
                .ToListAsync();
        }

        public async Task<bool> UpdateHealProcessAsync(HealProcess healProcess)
        {
            try
            {
                var existingHealProcess = await _DbContext.Employees.FindAsync(healProcess.HealProcessId);
                if (existingHealProcess != null)
                {
                    _DbContext.Entry(existingHealProcess).CurrentValues.SetValues(healProcess);
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

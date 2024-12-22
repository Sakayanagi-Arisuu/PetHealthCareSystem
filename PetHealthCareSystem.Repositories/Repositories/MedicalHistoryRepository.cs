using Microsoft.EntityFrameworkCore;
using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class MedicalHistoryRepository : IMedicalHistoryRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public MedicalHistoryRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddMedicalHistoryAsync(MedicalHistory history)
        {
            try
            {
                await _DbContext.MedicalHistories.AddAsync(history);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelMedicalHistoryAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.MedicalHistories.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.MedicalHistories.Remove(objDel);
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

        public async Task<bool> DelMedicalHistoryAsync(MedicalHistory history)
        {
            try
            {
                _DbContext.MedicalHistories.Remove(history);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<MedicalHistory>> GetAllMedicalHistoryAsync()
        {
            return await _DbContext.MedicalHistories
                .Include(m => m.Pet)
                .Include(m => m.Veterinarian)
                .ToListAsync();
        }

        public async Task<bool> UpdateMedicalHistoryAsync(MedicalHistory history)
        {
            try
            {
                var existingMedicalHistory = await _DbContext.MedicalHistories.FindAsync(history.MedicalHistoryId);
                if (existingMedicalHistory != null)
                {
                    _DbContext.Entry(existingMedicalHistory).CurrentValues.SetValues(history);
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

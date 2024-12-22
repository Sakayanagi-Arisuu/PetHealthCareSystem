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
    public class PetRepository : IPetRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public PetRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddPetAsync(Pet pet)
        {
            try
            {
                await _DbContext.Pets.AddAsync(pet);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelPetAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.Pets.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.Pets.Remove(objDel);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errol Delete Pet: {ex.Message}", ex);
            }
        }

        public async Task<bool> DelPetAsync(Pet pet)
        {
            try
            {
                _DbContext.Pets.Remove(pet);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Pet>> GetAllPetAsync()
        {
            return await _DbContext.Pets
                .Include(p => p.Customer)
                .ToListAsync();
        }

        public async Task<bool> UpdatePetAsync(Pet pet)
        {
            try
            {
                var existingPet = await _DbContext.Pets.FindAsync(pet.PetId);
                if (existingPet != null)
                {
                    _DbContext.Entry(existingPet).CurrentValues.SetValues(pet);
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

using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using PetHealthCareSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Services
{
    public class VeterinarianService : IVeterinarianSerice
    {
        private readonly IVeterinarianRepository _repository;
        public VeterinarianService(IVeterinarianRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddVeterinarianAsync(Veterinarian veterinarian)
        {
            return await _repository.AddVeterinarianAsync(veterinarian);
        }

        public async Task<bool> DeleteVeterinarianAsync(Veterinarian veterinarian)
        {
            return await _repository.DeleteVeterinarianAsync(veterinarian);
        }

        public async Task<bool> DelVeterinarianAsync(int id)
        {
            return await _repository.DelVeterinarianAsync(id);
        }

        public async Task<List<Veterinarian>> GetAllVeterinarianAsync()
        {
            return await _repository.GetAllVeterinarianAsync();
        }

        public async Task<bool> UpdateVeterinarianAsync(Veterinarian veterinarian)
        {
            return await _repository.UpdateVeterinarianAsync(veterinarian);
        }
    }
}

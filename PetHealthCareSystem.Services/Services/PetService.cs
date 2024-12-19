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
    public class PetService : IPetService
    {
        private readonly IPetRepository _repository;
        public PetService(IPetRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddPetAsync(Pet pet)
        {
            return await _repository.AddPetAsync(pet);
        }

        public async Task<bool> DeletePetAsync(Pet pet)
        {
            return await _repository.DeletePetAsync(pet);
        }

        public async Task<bool> DelPetAsync(int id)
        {
            return await _repository.DelPetAsync(id);
        }

        public async Task<List<Pet>> GetAllPetAsync()
        {
            return await _repository.GetAllPetAsync();
        }

        public async Task<bool> UpdatePetAsync(Pet pet)
        {
            return await (_repository.UpdatePetAsync(pet));
        }
    }
}

using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IPetService
    {
        Task<List<Pet>> GetAllPetAsync();
        Task<bool> DelPetAsync(int id);
        Task<bool> DeletePetAsync(Pet pet);
        Task<bool> UpdatePetAsync(Pet pet);
        Task<bool> AddPetAsync(Pet pet);
    }
}

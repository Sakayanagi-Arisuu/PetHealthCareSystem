using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IVeterinarianSerice
    {
        Task<List<Veterinarian>> GetAllVeterinarianAsync();
        Task<bool> DelVeterinarianAsync(int id);
        Task<bool> DeleteVeterinarianAsync(Veterinarian veterinarian);
        Task<bool> AddVeterinarianAsync(Veterinarian veterinarian);
        Task<bool> UpdateVeterinarianAsync(Veterinarian veterinarian);
    }
}

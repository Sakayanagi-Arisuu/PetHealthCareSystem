using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IVeterinarianRepository
    {
        Task<List<Veterinarian>> GetAllVeterinarian();
        Boolean DelVeterinarian(int id);
        Boolean DeleteVeterinarian(Veterinarian veterinarian);
        Boolean AddVeterinarian(Veterinarian veterinarian);
        Boolean UpdateVeterinarian(Veterinarian veterinarian);
    }
}

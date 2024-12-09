using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IPetRepository
    {
        Task<List<Pet>> GetAllPet();
        Boolean DelPet (int id);
        Boolean DeletePet (Pet pet);
        Boolean UpdatePet (Pet pet);
        Boolean AddPet (Pet pet);
    }
}

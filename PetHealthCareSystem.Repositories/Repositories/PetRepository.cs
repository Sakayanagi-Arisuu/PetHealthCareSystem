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
        public bool AddPet(Pet pet)
        {
            throw new NotImplementedException();
        }

        public bool DeletePet(Pet pet)
        {
            throw new NotImplementedException();
        }

        public bool DelPet(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pet>> GetAllPet()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePet(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}

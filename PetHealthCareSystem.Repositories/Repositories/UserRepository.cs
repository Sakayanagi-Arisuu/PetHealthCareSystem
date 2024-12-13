using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DelUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

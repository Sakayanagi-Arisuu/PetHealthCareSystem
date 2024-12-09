using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        Boolean DelUser (int id);
        Boolean AddUser (User user);
        Boolean DelUser (User user);
        Boolean UpdateUser (User user);
    }
}

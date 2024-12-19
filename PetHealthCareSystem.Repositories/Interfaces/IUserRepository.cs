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
        Task<List<User>> GetAllUserAsync();
        Task<bool> DelUserAsync (int id);
        Task<bool> AddUserAsync (User user);
        Task<bool> DelUserAsync (User user);
        Task<bool> UpdateUserAsync (User user);
    }
}

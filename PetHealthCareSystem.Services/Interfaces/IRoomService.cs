using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IRoomService
    {
        Task<List<Room>> GetAllRoomAsync();
        Task<bool> DelRoomAsync(int id);
        Task<bool> DeleteRoomAsync(Room room);
        Task<bool> AddRoomAsync(Room room);
        Task<bool> UpdateRoomAsync(Room room);
    }
}

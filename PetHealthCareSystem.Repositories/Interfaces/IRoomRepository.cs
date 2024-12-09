using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetAllRoom();
        Boolean DelRoom(int id);
        Boolean DeleteRoom(Room room);
        Boolean AddRoom(Room room);
        Boolean UpdateRoom(Room room);
    }
}

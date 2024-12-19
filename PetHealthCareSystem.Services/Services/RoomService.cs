using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using PetHealthCareSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _repository;
        public RoomService(IRoomRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddRoomAsync(Room room)
        {
            return await _repository.AddRoomAsync(room);
        }

        public async Task<bool> DeleteRoomAsync(Room room)
        {
            return await _repository.DeleteRoomAsync(room);
        }

        public async Task<bool> DelRoomAsync(int id)
        {
            return await _repository.DelRoomAsync(id);
        }

        public async Task<List<Room>> GetAllRoomAsync()
        {
            return await _repository.GetAllRoomAsync();
        }

        public async Task<bool> UpdateRoomAsync(Room room)
        {
            return await _repository.UpdateRoomAsync(room);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public RoomRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddRoomAsync(Room room)
        {
            try
            {
                await _DbContext.Rooms.AddAsync(room);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelRoomAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.Rooms.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.Rooms.Remove(objDel);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errol Delete Room: {ex.Message}", ex);
            }
        }

        public async Task<bool> DelRoomAsync(Room room)
        {
            try
            {
                _DbContext.Rooms.Remove(room);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Room>> GetAllRoomAsync()
        {
            return await _DbContext.Rooms
                .ToListAsync();
        }

        public async Task<bool> UpdateRoomAsync(Room room)
        {
            try
            {
                var extRoom = await _DbContext.Rooms.FindAsync(room.RoomId);
                if(extRoom != null)
                {
                    _DbContext.Entry(extRoom).CurrentValues.SetValues(room);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                Console.WriteLine($"Lỗi, không thể cập nhật: ");
                return false;
            }
        }
    }
}

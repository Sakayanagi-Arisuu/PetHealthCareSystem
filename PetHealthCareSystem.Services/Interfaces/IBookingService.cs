using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IBookingService
    {
        Task<List<Booking>> GetAllBookingAsync();
        Task<bool> DelBookingAsync(int id);
        Task<bool> DelBookingAsync(Booking booking);
        Task<bool> AddBookingAsync(Booking booking);
        Task<bool> UpdateBookingAsync(Booking booking);
    }
}

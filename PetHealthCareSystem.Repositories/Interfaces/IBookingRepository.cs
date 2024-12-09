using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        Task<List<Booking>> GetAllBooking();
        Boolean DelBooking (int id);
        Boolean DelBooking (Booking booking);
        Boolean AddBooking (Booking booking);
        Boolean UpdateBooking (Booking booking);
    }
}

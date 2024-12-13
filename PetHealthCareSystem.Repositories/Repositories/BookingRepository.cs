using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public bool AddBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public bool DelBooking(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Task<List<Booking>> GetAllBooking()
        {
            throw new NotImplementedException();
        }

        public bool UpdateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}

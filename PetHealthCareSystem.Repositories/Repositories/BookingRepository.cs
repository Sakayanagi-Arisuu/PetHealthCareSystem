using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PetHealthCareSystem.Repositories.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public BookingRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool>AddBookingAsync(Booking booking)
        {
            try
            {
                await _DbContext.Bookings.AddAsync(booking);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelBookingAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.Bookings.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.Bookings.Remove(objDel);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error deleting booking: {ex.Message}", ex);
            }
        }

        public async Task<bool> DelBookingAsync(Booking booking)
        {
            try
            {
                _DbContext.Bookings.Remove(booking);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Booking>> GetAllBookingAsync()
        {
            return await _DbContext.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Pet)
                .Include(b => b.Room)
                .Include(b => b.Veterinarian)
                .Include(b => b.Payments)
                .ToListAsync();
        }

        public async Task<bool> UpdateBookingAsync(Booking booking)
        {
            try
            {
                var existingBooking = await _DbContext.Bookings.FindAsync(booking.BookingId);
                if (existingBooking != null)
                {
                    _DbContext.Entry(existingBooking).CurrentValues.SetValues(booking);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}

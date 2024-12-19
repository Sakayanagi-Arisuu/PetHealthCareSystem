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
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repository;
        public BookingService(IBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddBookingAsync(Booking booking)
        {
            return await _repository.AddBookingAsync(booking);
        }

        public async Task<bool> DelBookingAsync(int id)
        {
            return await _repository.DelBookingAsync(id);
        }

        public async Task<bool> DelBookingAsync(Booking booking)
        {
            return await _repository.DelBookingAsync(booking);
        }

        public async Task<List<Booking>> GetAllBookingAsync()
        {
            return await _repository.GetAllBookingAsync();
        }
        public async Task<bool> UpdateBookingAsync(Booking booking)
        {
            return await _repository.UpdateBookingAsync(booking);
        }
    }
}

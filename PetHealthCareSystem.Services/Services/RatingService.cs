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
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _repository;
        public RatingService(IRatingRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddRatingAsync(Rating rating)
        {
            return await _repository.AddRatingAsync(rating);
        }

        public async Task<bool> DelRatingAsync(int id)
        {
            return await _repository.DelRatingAsync(id);
        }

        public async Task<bool> DelRatingAsync(Rating rating)
        {
            return await _repository.DelRatingAsync(rating);
        }

        public async Task<List<Rating>> GetAllRatingAsync()
        {
            return await _repository.GetAllRatingAsync();
        }

        public async Task<bool> UpdateRatingAsync(Rating rating)
        {
            return await _repository.UpdateRatingAsync(rating);
        }
    }
}

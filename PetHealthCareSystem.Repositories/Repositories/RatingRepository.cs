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
    public class RatingRepository : IRatingRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public RatingRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddRatingAsync(Rating rating)
        {
            try
            {
                await _DbContext.Ratings.AddAsync(rating);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelRatingAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.Ratings.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.Ratings.Remove(objDel);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errol Delete Rating: {ex.Message}", ex);
            }
        }

        public async Task<bool> DelRatingAsync(Rating rating)
        {
            try
            {
                _DbContext.Ratings.Remove(rating);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Rating>> GetAllRatingAsync()
        {
            return await _DbContext.Ratings
                .Include(r => r.Customer)
                .Include(r =>r.Service)
                .ToListAsync();
        }

        public async Task<bool> UpdateRatingAsync(Rating rating)
        {
            try
            {
                var existingRating = await _DbContext.Ratings.FindAsync(rating.RatingId);
                if (existingRating != null)
                {
                    _DbContext.Entry(existingRating).CurrentValues.SetValues(rating);
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

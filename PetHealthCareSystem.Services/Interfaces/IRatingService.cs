using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Services.Interfaces
{
    public interface IRatingService
    {
        Task<List<Rating>> GetAllRatingAsync();
        Task<bool> DelRatingAsync(int id);
        Task<bool> DelRatingAsync(Rating rating);
        Task<bool> AddRatingAsync(Rating rating);
        Task<bool> UpdateRatingAsync(Rating rating);
    }
}

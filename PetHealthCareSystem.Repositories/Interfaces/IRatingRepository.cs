using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IRatingRepository
    {
        Task<List<Rating>> GetAllRating();
        Boolean DelRating(int id);
        Boolean DelRating (Rating rating);
        Boolean AddRating(Rating rating);
        Boolean UpdateRating(Rating rating);
    }
}

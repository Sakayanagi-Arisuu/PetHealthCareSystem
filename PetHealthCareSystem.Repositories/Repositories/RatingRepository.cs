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
        public bool AddRating(Rating rating)
        {
            throw new NotImplementedException();
        }

        public bool DelRating(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelRating(Rating rating)
        {
            throw new NotImplementedException();
        }

        public Task<List<Rating>> GetAllRating()
        {
            throw new NotImplementedException();
        }

        public bool UpdateRating(Rating rating)
        {
            throw new NotImplementedException();
        }
    }
}

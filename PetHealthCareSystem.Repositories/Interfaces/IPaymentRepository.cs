using PetHealthCareSystem.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Interfaces
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetAllPaymentAsync();
        Task<bool> DelPaymentAsync (int id);
        Task<bool> DelPaymentAsync (Payment payment);
        Task<bool> AddPaymentAsync (Payment payment);
        Task<bool> UpdatePaymentAsync (Payment payment);
    }
}

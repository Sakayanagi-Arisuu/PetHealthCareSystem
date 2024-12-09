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
        Task<List<Payment>> GetAllPayment();
        Boolean DelPayment (int id);
        Boolean DelPayment (Payment payment);
        Boolean AddPayment (Payment payment);
        Boolean UpdatePayment (Payment payment);
    }
}

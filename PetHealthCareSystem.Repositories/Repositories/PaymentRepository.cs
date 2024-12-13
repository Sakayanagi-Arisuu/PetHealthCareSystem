using PetHealthCareSystem.Repositories.Entities;
using PetHealthCareSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCareSystem.Repositories.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public bool AddPayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public bool DelPayment(int id)
        {
            throw new NotImplementedException();
        }

        public bool DelPayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public Task<List<Payment>> GetAllPayment()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePayment(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}

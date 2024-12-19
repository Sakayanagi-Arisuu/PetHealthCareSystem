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
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repository;
        public PaymentService(IPaymentRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddPaymentAsync(Payment payment)
        {
            return await _repository.AddPaymentAsync(payment);
        }

        public async Task<bool> DelPaymentAsync(int id)
        {
            return await (_repository.DelPaymentAsync(id));
        }

        public async Task<bool> DelPaymentAsync(Payment payment)
        {
            return await _repository.DelPaymentAsync(payment);
        }

        public async Task<List<Payment>> GetAllPaymentAsync()
        {
            return await _repository.GetAllPaymentAsync();
        }

        public async Task<bool> UpdatePaymentAsync(Payment payment)
        {
            return await _repository.UpdatePaymentAsync(payment);
        }
    }
}

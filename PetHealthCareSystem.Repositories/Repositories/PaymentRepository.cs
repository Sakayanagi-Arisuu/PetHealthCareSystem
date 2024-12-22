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
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PetHealthCareSystemContext _DbContext;
        public PaymentRepository(PetHealthCareSystemContext dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task<bool> AddPaymentAsync(Payment payment)
        {
            try
            {
                await _DbContext.Payments.AddAsync(payment);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelPaymentAsync(int id)
        {
            try
            {
                var objDel = await _DbContext.Payments.FindAsync(id);
                if (objDel != null)
                {
                    _DbContext.Payments.Remove(objDel);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Errol Delete Payment: {ex.Message}", ex);
            }
        }

        public async Task<bool> DelPaymentAsync(Payment payment)
        {
            try
            {
                _DbContext.Payments.Remove(payment);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Payment>> GetAllPaymentAsync()
        {
            return await _DbContext.Payments
                .Include(p => p.Booking)
                .ToListAsync();
        }

        public async Task<bool> UpdatePaymentAsync(Payment payment)
        {
            try
            {
                var existingPayment = await _DbContext.Payments.FindAsync(payment.PaymentId);
                if (existingPayment != null)
                {
                    _DbContext.Entry(existingPayment).CurrentValues.SetValues(payment);
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

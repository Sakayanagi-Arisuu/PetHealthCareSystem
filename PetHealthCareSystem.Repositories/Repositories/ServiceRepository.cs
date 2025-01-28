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
    public class ServiceRepository : IServiceRepository
    {
        private readonly PetHealthCareSystemContext _Dbcontext;
        public ServiceRepository(PetHealthCareSystemContext dbcontext)
        {
            _Dbcontext = dbcontext;
        }
        public async Task<bool> AddServiceAsync(Service service)
        {
            try
            {
                await _Dbcontext.Services.AddAsync(service);
                await _Dbcontext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelServiceAsync(Service service)
        {
            try
            {
                _Dbcontext.Services.Remove(service);
                await _Dbcontext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DelServiceAsync(int id)
        {
            try
            {
                var objDel = await _Dbcontext.Services.FindAsync(id);
                if (objDel != null)
                {
                    _Dbcontext.Services.Remove(objDel);
                    await _Dbcontext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errol Delete Room: {ex.Message}", ex);
            }
            
        }

        public async Task<List<Service>> GetAllServiceAsync()
        {
            return await _Dbcontext.Services
                .ToListAsync();
        }

        public async Task<bool> UpdateServiceAsync(Service service)
        {
            try
            {
                var extService = await _Dbcontext.Services.FindAsync(service.ServiceId);
                if (extService != null)
                {
                    _Dbcontext.Entry(extService).CurrentValues.SetValues(service);
                    await _Dbcontext.SaveChangesAsync();
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

using Microsoft.EntityFrameworkCore;
using SR2.Data;
using SR2.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SR2.Services
{
    public class VehicleTypeRepository : IVehicleTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<VehicleType> GetVehicleType(Guid id)
        {
            return await _context.VehicleType.FirstOrDefaultAsync(x => x.VehicleTypeId.Equals(id));
        }

        public async Task<List<VehicleType>> GetVehicleTypes()
        {
            return await _context.VehicleType.ToListAsync();
        }

        public async Task<bool> Save(VehicleType vehicleType)
        {
            try
            {
                vehicleType.VehicleTypeId = Guid.NewGuid();
                _context.VehicleType.Add(vehicleType);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Task<bool> Update(VehicleType vehicleType)
        {
            throw new NotImplementedException();
        }
    }
}

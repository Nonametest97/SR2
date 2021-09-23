using SR2.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SR2.Services
{
    public interface IVehicleTypeRepository
    {
        Task<List<VehicleType>> GetVehicleTypes();
        Task<VehicleType> GetVehicleType(Guid id);
        Task<bool> Save(VehicleType vehicleType);
        Task<bool> Update(VehicleType vehicleType);
        Task<bool> Delete(Guid id);
    }
}

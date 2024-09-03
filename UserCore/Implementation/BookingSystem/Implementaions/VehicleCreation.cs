using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserInfrastructure;
using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Implementaions
{
    public class VehicleCreation : IVehicleCreation
    {
        private readonly UserDBcontext _userDBcontext;

        public VehicleCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreateVehicle(VehicleRequestModel vehicleRequest)
        {

            var vehicle = new Vehicle()
            {
                VehicleId = vehicleRequest.VehicleId,
                Brand = vehicleRequest.Brand,
                Name = vehicleRequest.Name,
                LicensePlateNumber = vehicleRequest.LicensePlateNumber,
                InsuranceNumber = vehicleRequest.InsuranceNumber,
                InsuranceExpiryDate = vehicleRequest.InsuranceExpiryDate,
                IsActive = vehicleRequest.IsActive,
                Price = vehicleRequest.Price,
            };
            _userDBcontext.Vehicle.Add(vehicle);
            _userDBcontext.SaveChanges();
        }
    }
}

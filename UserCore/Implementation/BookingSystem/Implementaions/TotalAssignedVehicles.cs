using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserInfrastructure;
using UserModel.BookingSystem;
using static UserModel.BookingSystem.AssignedVehicleResponseModel;

namespace UserCore.Implementation.BookingSystem.Implementaions
{

    public class TotalAssignedVehicles : ITotalAssignedVehicles
    {
        private readonly UserDBcontext _userDBcontext;

        public TotalAssignedVehicles(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public List<AssignedVehicleResponseModel> GetAssignedVehicles()
        {
            var today = DateTime.Today;
            var assignedVehicles = _userDBcontext.Booking
                .Where(b => b.ReturnDate > today)
                .Include(b => b.Vehicle)
                .Include(b => b.Customer)
                .Select(b => new AssignedVehicleResponseModel
                {
                    BookingID = b.BookingId,
                    VehicleID = b.Vehicle.VehicleId,
                    Brand = b.Vehicle.Brand,
                    Name = b.Vehicle.Name,
                    LicensePlateNumber = b.Vehicle.LicensePlateNumber,
                    CustomerID = b.Customer.CustomerId,
                    CustomerName = b.Customer.FirstName + " " + b.Customer.LastName,
                    StartingLocation = b.StartingLocation,
                    EndingLocation = b.EndingLocation,
                    RentDate = b.RentDate,
                    ReturnDate = b.ReturnDate,
                    BookingCost = b.BookingCost
                })
                .ToList();

            return assignedVehicles;
        }
    }
}

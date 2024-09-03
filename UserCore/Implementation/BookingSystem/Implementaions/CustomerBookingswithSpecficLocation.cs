using Microsoft.EntityFrameworkCore;
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
    public class CustomerBookingswithSpecficLocation : ICustomerBookingswithSpecificLocation
    {
        private readonly UserDBcontext _userDBcontext;
        public CustomerBookingswithSpecficLocation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public List<Customer> CustomerWithSpecificLocationTraveled(string travelLocation)
        {
            var result = _userDBcontext.Booking
                        .Include(c=>c.Customer)
                        .Where(c=>c.StartingLocation.Contains(travelLocation))
                        .Select(c=>c.Customer)
                        .Distinct()
                        .ToList();
            return result;
        }
    }
}

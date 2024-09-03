using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserInfrastructure;

namespace UserCore.Implementation.BookingSystem.Implementaions
{
    public class TotalAmountEarnedByRentedVehicle : ITotalAmountEarnedByRentedVehicle
    {
        private readonly UserDBcontext _userDBcontext;

        public TotalAmountEarnedByRentedVehicle(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public decimal GetTotalAmount()
        {
            //var today = DateTime.Today;
            var totalAmount = _userDBcontext.Booking
                            .Where(i => i.ReturnDate <= DateTime.Today).Sum(i => i.BookingCost);
            return totalAmount;
        }
    }
}

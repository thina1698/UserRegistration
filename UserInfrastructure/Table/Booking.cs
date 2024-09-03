using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.BookingSystem
{
    public class Booking
    {
        public int BookingId {  get; set; }
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public string StartingLocation { get; set; }
        public string EndingLocation { get; set; }

        [Precision(18,2)]
        public Decimal BookingCost {  get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }

    }
}

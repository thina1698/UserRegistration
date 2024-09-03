using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.BookingSystem
{
    public class BookingRequestModel
    {
        public int BookingId { get; set; }
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public string StartingLocation { get; set; }
        public string EndingLocation { get; set; }

        public Decimal BookingCost { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}

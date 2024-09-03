using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.BookingSystem
{
    public class AssignedVehicleResponseModel
    {
            public int BookingID { get; set; }
            public int VehicleID { get; set; }
            public string Brand { get; set; }
            public string Name { get; set; }
            public string LicensePlateNumber { get; set; }
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string StartingLocation { get; set; }
            public string EndingLocation { get; set; }
            public DateTime RentDate { get; set; }
            public DateTime? ReturnDate { get; set; }
            public decimal BookingCost { get; set; }
        }
}

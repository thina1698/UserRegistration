using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.BookingSystem
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string LicensePlateNumber { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime InsuranceExpiryDate { get; set; }
        public bool IsActive { get; set; }

        [Precision(18,2)]
        public Decimal Price {  get; set; }

    }
}

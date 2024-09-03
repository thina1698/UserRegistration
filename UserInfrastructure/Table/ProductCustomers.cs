using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfrastructure.Table
{
    public class ProductCustomers
    {
        public int ProductCustomersId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
}

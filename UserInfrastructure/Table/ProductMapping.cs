using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel.BookingSystem;

namespace UserInfrastructure.Table
{
    public class ProductMapping
    {
        public int ProductMappingId { get; set; }
        public int ProductCustomersId { get; set; }
        public int ProductsId { get; set; }
        public ProductCustomers ProductCustomer { get; set; }
        public Products Products { get; set; }

    }
}

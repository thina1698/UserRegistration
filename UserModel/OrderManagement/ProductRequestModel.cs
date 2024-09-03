using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.OrderManagement
{
    public class ProductRequestModel
    {
        public int ProductsId { get; set; }
        public string ProductName { get; set; }
        public Decimal ProductPrice { get; set; }
    }
}

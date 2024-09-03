using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfrastructure.Table
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string ProductName { get; set; }

        [Precision(18, 2)]
        public Decimal ProductPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.OrderManagement
{
    public class MappingRequestModel
    {
        //public int ProductMappingId { get; set; }
        public int ProductCustomersId { get; set; }
        public List<int> ProductsId { get; set; }
    }
}

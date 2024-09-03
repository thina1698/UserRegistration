using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.OrderManagement;
using Microsoft.EntityFrameworkCore;

namespace UserCore.Implementation.OrderManagement
{
    public class MappingCreation : IMappingCreation
    {

        private readonly UserDBcontext _userDBcontext;

        public MappingCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreateMapping(MappingRequestModel requestModel)
        {

            var customerProductMapping = requestModel.ProductsId.Select(b => new ProductMapping()
            {
                ProductCustomersId = requestModel.ProductCustomersId,
                ProductsId = b,
            });
            
            _userDBcontext.ProductMapping.AddRange(customerProductMapping);
            _userDBcontext.SaveChanges();
        }
    }
}

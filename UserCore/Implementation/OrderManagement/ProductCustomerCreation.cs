using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.UserModel;
using UserModel.OrderManagement;

namespace UserCore.Implementation.OrderManagement
{
    public class ProductCustomerCreation : IProductCustomerCreation
    {

        private readonly UserDBcontext _userDBcontext;

        public ProductCustomerCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreateProductCustomer(ProductCustomerRequestModel requestModel)
        {

            var productCustomer = new ProductCustomers()
            {
                ProductCustomersId = requestModel.ProductCustomersId,
                CustomerName = requestModel.CustomerName,
                MobileNumber = requestModel.MobileNumber,
                Age = requestModel.Age,
                Address = requestModel.Address,
            };
            _userDBcontext.ProductCustomers.Add(productCustomer);
            _userDBcontext.SaveChanges();
        }
    }
}

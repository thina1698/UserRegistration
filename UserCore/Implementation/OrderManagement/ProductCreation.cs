using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.OrderManagement;

namespace UserCore.Implementation.OrderManagement
{
    public class ProductCreation : IProductCreation
    {
        private readonly UserDBcontext _userDBcontext;

        public ProductCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreateProducts(ProductRequestModel requestModel)
        {

            var product = new Products()
            {
                ProductsId = requestModel.ProductsId,
                ProductName = requestModel.ProductName,
                ProductPrice = requestModel.ProductPrice,

            };
            _userDBcontext.Products.Add(product);
            _userDBcontext.SaveChanges();
        }

    }
}

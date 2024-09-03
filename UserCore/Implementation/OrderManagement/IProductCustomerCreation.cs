using UserModel.OrderManagement;

namespace UserCore.Implementation.OrderManagement
{
    public interface IProductCustomerCreation
    {
        void CreateProductCustomer(ProductCustomerRequestModel requestModel);
    }
}
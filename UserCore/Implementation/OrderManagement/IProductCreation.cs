using UserModel.OrderManagement;

namespace UserCore.Implementation.OrderManagement
{
    public interface IProductCreation
    {
        void CreateProducts(ProductRequestModel requestModel);
    }
}
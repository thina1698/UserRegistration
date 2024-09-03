using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface ICustomerCreation
    {
        void CreateCustomer(CustomerRequestModel customerRequest);
    }
}
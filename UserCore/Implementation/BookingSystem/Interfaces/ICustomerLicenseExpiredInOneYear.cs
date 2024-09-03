using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface ICustomerLicenseExpiredInOneYear
    {
        List<CustomerRequestModel> LicenseExpiryInOneYear();
    }
}
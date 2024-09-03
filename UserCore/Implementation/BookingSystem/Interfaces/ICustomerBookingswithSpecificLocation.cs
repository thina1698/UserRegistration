using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface ICustomerBookingswithSpecificLocation
    {
        List<Customer> CustomerWithSpecificLocationTraveled(string travelLocation);
    }
}
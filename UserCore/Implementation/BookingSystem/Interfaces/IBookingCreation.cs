using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface IBookingCreation
    {
        void CreateBooking(BookingRequestModel bookingRequest);
    }
}
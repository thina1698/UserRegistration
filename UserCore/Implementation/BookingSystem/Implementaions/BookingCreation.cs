using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserInfrastructure;
using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Implementaions
{
    public class BookingCreation : IBookingCreation
    {
        private readonly UserDBcontext _userDBcontext;

        public BookingCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreateBooking(BookingRequestModel bookingRequest)
        {

            var booking = new Booking()
            {
                BookingId = bookingRequest.BookingId,
                VehicleID = bookingRequest.VehicleID,
                CustomerID = bookingRequest.CustomerID,
                StartingLocation = bookingRequest.StartingLocation,
                EndingLocation = bookingRequest.EndingLocation,
                RentDate = bookingRequest.RentDate,
                ReturnDate = bookingRequest.ReturnDate,
            };
            _userDBcontext.Booking.Add(booking);
            _userDBcontext.SaveChanges();
        }
    }
}

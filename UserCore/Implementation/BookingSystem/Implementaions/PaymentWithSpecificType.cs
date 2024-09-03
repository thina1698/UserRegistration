using Azure;
using Microsoft.EntityFrameworkCore;
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
    public class PaymentWithSpecificType : IPaymentWithSpecificType
    {
        private readonly UserDBcontext _userDBcontext;
        public PaymentWithSpecificType(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public List<SpecficPaymentResponseModel> SpecificPaymentType(string typeOfPayment)
        {
            var response = _userDBcontext.Payment
                            .Include(p => p.Booking) 
                            .ThenInclude(b => b.Customer) 
                            .Include(p => p.PaymentMode) 
                            .Where(p => p.PaymentMode.PaymentModeType == typeOfPayment)
                            .Select(p => new SpecficPaymentResponseModel
                            {
                                CustomerId = p.Booking.Customer.CustomerId,
                                Name = p.Booking.Customer.FirstName,
                                Email = p.Booking.Customer.EmailId,
                                PaymentModeType = p.PaymentMode.PaymentModeType
                            }).ToList();
            return response;

        }

    }
}

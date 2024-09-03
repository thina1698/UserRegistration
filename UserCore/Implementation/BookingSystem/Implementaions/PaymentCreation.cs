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
    public class PaymentCreation : IPaymentCreation
    {
        private readonly UserDBcontext _userDBcontext;

        public PaymentCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreatePayment(PaymentRequestModel paymentRequest)
        {
            var payment = new Payment()
            {
                PaymentId = paymentRequest.PaymentId,
                BookingId = paymentRequest.BookingId,
                PaymentModeId = paymentRequest.PaymentModeId,
                IsPaid = paymentRequest.IsPaid,
            };
            _userDBcontext.Payment.Add(payment);
            _userDBcontext.SaveChanges();
        }
    }
}

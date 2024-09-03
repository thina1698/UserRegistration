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
    public class PaymentModeCreation : IPaymentModeCreation
    {
        private readonly UserDBcontext _userDBcontext;

        public PaymentModeCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreatePaymentMode(PaymentModeRequestModel paymentModeRequest)
        {

            var paymentMode = new PaymentMode()
            {
                PaymentModeId = paymentModeRequest.PaymentModeId,
                PaymentModeType = paymentModeRequest.PaymentModeType,
            };
            _userDBcontext.PaymentMode.Add(paymentMode);
            _userDBcontext.SaveChanges();
        }
    }
}

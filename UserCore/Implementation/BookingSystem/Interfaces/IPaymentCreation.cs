using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface IPaymentCreation
    {
        void CreatePayment(PaymentRequestModel paymentRequest);
    }
}
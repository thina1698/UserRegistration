using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface IPaymentModeCreation
    {
        void CreatePaymentMode(PaymentModeRequestModel paymentModeRequest);
    }
}
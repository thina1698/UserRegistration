using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface IPaymentWithSpecificType
    {
        List<SpecficPaymentResponseModel> SpecificPaymentType(string typeOfPayment);
    }
}
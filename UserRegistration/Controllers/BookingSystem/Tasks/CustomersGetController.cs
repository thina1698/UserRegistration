using Microsoft.AspNetCore.Mvc;
using UserCommonApi;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserModel.BookingSystem;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers.BookingSystem.Tasks
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersGetController : ControllerBase
    {

        private readonly ICustomerLicenseExpiredInOneYear _licenseExpiredInOneYear;
        private readonly IPaymentWithSpecificType _paymentWithSpecific;
        private readonly ICustomerBookingswithSpecificLocation _bookingswithSpecificLocation;
        private readonly ICustomerInfo _customerInfo;

        public CustomersGetController
         (
            ICustomerLicenseExpiredInOneYear licenseExpiredInOneYear,
            IPaymentWithSpecificType paymentWithSpecific,
            ICustomerBookingswithSpecificLocation bookingswithSpecificLocation,
            ICustomerInfo customerInfo
         )
        {
            _licenseExpiredInOneYear = licenseExpiredInOneYear;
            _paymentWithSpecific = paymentWithSpecific;
            _bookingswithSpecificLocation = bookingswithSpecificLocation;
            _customerInfo = customerInfo;
        }

        // GET api/<CustomersGetController>/5
        [HttpGet("CustomerLicenseExpiryWithinOneyear")]
        public CommonApiResponse Get()
        {
            var getData = _licenseExpiredInOneYear.LicenseExpiryInOneYear();
            return new CommonApiResponse()
            {
                Data = getData,
                Message="Customer with their License Expiring Details Fetched"
            };
        }

        [HttpGet("CustomerWithSpecificPaymentType")]
        public CommonApiResponse GetPaymentType(string typeOfPayment)
        {
            var getData = _paymentWithSpecific.SpecificPaymentType(typeOfPayment);
            return new CommonApiResponse()
            {
                Data = getData,
                Message = "Customer Details with their Specific Payment Type Details are Fetched"
            };
        }

        [HttpGet("CustomerWithLocationTraveled")]
        public CommonApiResponse GetLocationType(string traveledLocation)
        {
            var getData = _bookingswithSpecificLocation
                            .CustomerWithSpecificLocationTraveled(traveledLocation);
            return new CommonApiResponse()
            {
                Data = getData,
                Message = "Customer Details with traveled Location type Fetched"
            };
        }


        [HttpGet("GetAllTheCustomers")]
        public CommonApiResponse GetAllCustomers()
        {
            var getData = _customerInfo.getAllCustomer();
            return new CommonApiResponse()
            {
                Data = getData,
                Message = "All Customer Details Fetched"
            };
        }




    }
}

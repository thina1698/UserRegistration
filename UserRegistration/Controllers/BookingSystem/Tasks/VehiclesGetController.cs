using Microsoft.AspNetCore.Mvc;
using System.Net;
using UserCommonApi;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserModel.BookingSystem;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers.BookingSystem.Tasks
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesGetController : ControllerBase
    {

        private readonly ITotalAmountEarnedByRentedVehicle _totalAmountEarnedByRentedVehicle;
        private readonly ITotalAssignedVehicles _totalAssignedVehicles;

        public VehiclesGetController
         (
            ITotalAmountEarnedByRentedVehicle totalAmountEarnedByRentedVehicle,
            ITotalAssignedVehicles totalAssignedVehicles
         )
        {
            _totalAmountEarnedByRentedVehicle = totalAmountEarnedByRentedVehicle;
            _totalAssignedVehicles = totalAssignedVehicles;
        }
        // GET: api/<VehiclesGetController>
        [HttpGet("TotalAmountEarnedByReturnedVehicles")]
        public CommonApiResponse GetTotalAmount()
        {
            decimal getData = _totalAmountEarnedByRentedVehicle.GetTotalAmount();

            return new CommonApiResponse
            {
                httpStatusCode = HttpStatusCode.OK,
                Data = getData,
                Message = $"Total Amount Fetched Successfully,The total Amount is {getData}",
            };
        }

        // GET api/<VehiclesGetController>/5
        [HttpGet("TotalAssignedVehiclesForTheBooking")]
        public CommonApiResponse GetAssignedVehicles()
        {
            List<AssignedVehicleResponseModel> getData = _totalAssignedVehicles.GetAssignedVehicles();
            return new CommonApiResponse
            {
                httpStatusCode = HttpStatusCode.OK,
                Data = getData,
                Message = "Assigned Vehicles Details Fetched Successfully."
            };
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserModel.BookingSystem;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers.BookingSystem
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleCreation _vehicleCreation;
        public VehicleController(IVehicleCreation vehicleCreation)
        {
            _vehicleCreation = vehicleCreation;
        }
        // GET: api/<VehicleController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<VehicleController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<VehicleController>
        [HttpPost]
        public void Post([FromBody] VehicleRequestModel vehicleRequest)
        {
            _vehicleCreation.CreateVehicle(vehicleRequest);
        }

        // PUT api/<VehicleController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<VehicleController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

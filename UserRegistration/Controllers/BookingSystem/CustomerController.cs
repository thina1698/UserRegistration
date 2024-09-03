using Microsoft.AspNetCore.Mvc;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserCore.Interface;
using UserModel.BookingSystem;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers.BookingSystem
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerCreation _customerCreation;
        public CustomerController(ICustomerCreation customerCreation)
        {
            _customerCreation=customerCreation;
        }

        // GET: api/<CustomerController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<CustomerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerRequestModel customerRequest)
        {
            _customerCreation.CreateCustomer(customerRequest);
        }

        // PUT api/<CustomerController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CustomerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

using Microsoft.AspNetCore.Mvc;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserModel.BookingSystem;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers.BookingSystem
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentModeController : ControllerBase
    {

        private readonly IPaymentModeCreation _paymentModeCreation;
        public PaymentModeController(IPaymentModeCreation paymentModeCreation)
        {
            _paymentModeCreation = paymentModeCreation;
        }
        // GET: api/<PaymentModeController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<PaymentModeController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PaymentModeController>
        [HttpPost]
        public void Post([FromBody] PaymentModeRequestModel paymentModeRequest)
        {
            _paymentModeCreation.CreatePaymentMode(paymentModeRequest);
        }

        // PUT api/<PaymentModeController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PaymentModeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

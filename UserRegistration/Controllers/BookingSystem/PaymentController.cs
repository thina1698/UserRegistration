using Microsoft.AspNetCore.Mvc;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserModel.BookingSystem;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers.BookingSystem
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        private readonly IPaymentCreation _paymentCreation;
        public PaymentController(IPaymentCreation paymentCreation)
        {
            _paymentCreation = paymentCreation;
        }
        // GET: api/<PaymentController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<PaymentController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PaymentController>
        [HttpPost]
        public void Post([FromBody] PaymentRequestModel paymentRequest)
        {
            _paymentCreation.CreatePayment(paymentRequest);
        }

        // PUT api/<PaymentController>/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody] string value)
    //    {
    //    }

    //    // DELETE api/<PaymentController>/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //    }
    }
}

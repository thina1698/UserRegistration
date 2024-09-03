﻿using Microsoft.AspNetCore.Mvc;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserModel.BookingSystem;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers.BookingSystem
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IBookingCreation _bookingCreation;
        public BookingController(IBookingCreation bookingCreation)
        {
            _bookingCreation = bookingCreation;
        }

        // GET: api/<BookingController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<BookingController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<BookingController>
        [HttpPost]
        public void Post([FromBody] BookingRequestModel bookingRequest)
        {
            _bookingCreation.CreateBooking(bookingRequest);
        }

        //// PUT api/<BookingController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BookingController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

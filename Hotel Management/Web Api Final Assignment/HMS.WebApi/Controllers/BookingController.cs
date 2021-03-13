using HMS.BAL.Interfaces;
using HMS.Models.Models;
using HMS.WebApi.AuthenticationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMS.WebApi.Controllers
{
    [AuthenticationFilter]
    public class BookingController : ApiController
    {
        private readonly IBookingManager _bookingM;
        public BookingController(IBookingManager bookingM)
        {
            _bookingM = bookingM;
        }

        [HttpGet]
        [Route("api/Booking/allBooking")]
        public IHttpActionResult changeBooking()
        {
            return Ok(_bookingM.getAllBooking());
        }

        [HttpPut]
        [Route("api/Booking/updateBooking")]
        public IHttpActionResult changeBooking([FromBody]Booking model)
        {
            return Ok(_bookingM.updateBooking(model));
        }

        [HttpPut]
        [Route("api/Booking/updateStatus")]
        public IHttpActionResult changeBookingStatus([FromBody]Booking model)
        {
            return Ok(_bookingM.updateBookingStatus(model));
        }

        [HttpPut]
        [Route("api/Booking/deleteBooking")]
        public IHttpActionResult deleteBooking([FromBody]Booking model)
        {
            return Ok(_bookingM.deleteBooking(model));
        }
    }
}

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
<<<<<<< HEAD
        private readonly IBookingManager _bManager;
        public BookingController(IBookingManager bManager)
        {
            _bManager = bManager;
=======
        private readonly IBookingManager _bookingM;
        public BookingController(IBookingManager bookingM)
        {
            _bookingM= bookingM;
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        }

        [HttpGet]
        [Route("api/Booking/allBooking")]
        public IHttpActionResult changeBooking()
        {
<<<<<<< HEAD
            return Ok(_bManager.getAllBooking());
        }

        [HttpPut]
        [Route("api/Booking/updateBooking")]
        public IHttpActionResult changeBooking([FromBody]Booking model)
        {
            return Ok(_bManager.updateBooking(model));
        }

        [HttpPut]
        [Route("api/Booking/updateStatus")]
        public IHttpActionResult changeBookingStatus([FromBody]Booking model)
        {
            return Ok(_bManager.updateBookingStatus(model));
        }

        [HttpPut]
        [Route("api/Booking/deleteBooking")]
        public IHttpActionResult deleteBooking([FromBody]Booking model)
        {
            return Ok(_bManager.deleteBooking(model));
=======
            return Ok(_bookingM.getAllBooking());
        }

        [HttpPut]
        [Route("api/booking/updateBooking")]
        public IHttpActionResult changeBooking([FromBody]Booking model)
        {
            return Ok(_bookingM.updateBooking(model));
        }

        [HttpPut]
        [Route("api/booking/updateStatus")]
        public IHttpActionResult changeBookingStatus([FromBody]Booking model)
        {
            return Ok(_bookingM.updateBookingStatus(model));
        }

        [HttpPut]
        [Route("api/booking/deleteBooking")]
        public IHttpActionResult deleteBooking([FromBody]Booking model)
        {
            return Ok(_bookingM.deleteBooking(model));
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        }
    }
}

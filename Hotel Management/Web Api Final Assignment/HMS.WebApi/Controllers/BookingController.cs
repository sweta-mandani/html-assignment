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
        private readonly IBookingManager _bManager;
        public BookingController(IBookingManager bManager)
        {
            _bManager = bManager;
        }

        [HttpGet]
        [Route("api/Booking/allBooking")]
        public IHttpActionResult changeBooking()
        {
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
        }
    }
}

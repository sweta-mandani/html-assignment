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
    public class RoomController : ApiController
    {
        private readonly IRoomManager _rManager;
        public RoomController(IRoomManager rManager)
        {
            _rManager = rManager;
        }

        [HttpGet]
        [Route("api/RoomBooking/allRoom")]
        public IHttpActionResult allRooms(string city = null, decimal? pincode = null, int? price = null, string category = null)
        {
            return Ok(_rManager.searchRoom(city,pincode,price,category));
        }

        [HttpPost]
        [Route("api/RoomBooking/createRoom")]
        public IHttpActionResult makeARoom([FromBody]Room model)
        {
            return Ok(_rManager.createRoom(model));
        }

        [HttpGet]
        [Route("api/RoomBooking/checkRoom/{id}/{date}")]
        public IHttpActionResult makeARoom(int id,DateTime date)
        {
            return Ok(_rManager.checkRoomAvailability(id,date));
        }

        [HttpPost]
        [Route("api/RoomBooking/bookRoom")]
        public IHttpActionResult bookARoom([FromBody]Booking model)
        {
            return Ok(_rManager.bookRoom(model));
        }
    }
}

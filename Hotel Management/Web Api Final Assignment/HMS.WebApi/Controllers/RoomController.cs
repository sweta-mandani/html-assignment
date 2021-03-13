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
        private readonly IRoomManager _roomM;
        public RoomController(IRoomManager roomM)
        {
            _roomM= roomM;
        }

        [HttpGet]
        [Route("api/room/allRoom")]
        public IHttpActionResult allRooms(string city = null, decimal? pincode = null, int? price = null, string category = null)
        {
            return Ok(_roomM.searchRoom(city,pincode,price,category));
        }

        [HttpPost]
        [Route("api/room/createRoom")]
        public IHttpActionResult makeARoom([FromBody]Room model)
        {
            return Ok(_roomM.createRoom(model));
        }

        [HttpGet]
        [Route("api/room/checkRoom/{id}/{date}")]
        public IHttpActionResult makeARoom(int id,DateTime date)
        {
            return Ok(_roomM.checkRoomAvailability(id,date));
        }

        [HttpPost]
        [Route("api/room/bookRoom")]
        public IHttpActionResult bookARoom([FromBody]Booking model)
        {
            return Ok(_roomM.bookRoom(model));
        }
    }
}

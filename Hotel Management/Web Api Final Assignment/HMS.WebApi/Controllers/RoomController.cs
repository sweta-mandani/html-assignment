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
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/RoomController.cs
        private readonly IRoomManager _rManager;
        public RoomController(IRoomManager rManager)
        {
            _rManager = rManager;
=======
        private readonly IRoomManager _roomM;
        public RoomController(IRoomManager roomM)
        {
            _roomM = roomM;
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/RoomController.cs
        }

        [HttpGet]
        [Route("api/RoomBooking/allRoom")]
        public IHttpActionResult allRooms(string city = null, decimal? pincode = null, int? price = null, string category = null)
        {
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/RoomController.cs
            return Ok(_rManager.searchRoom(city,pincode,price,category));
=======
            return Ok(_roomM.searchRoom(city,pincode,price,category));
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/RoomController.cs
        }

        [HttpPost]
        [Route("api/RoomBooking/createRoom")]
        public IHttpActionResult makeARoom([FromBody]Room model)
        {
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/RoomController.cs
            return Ok(_rManager.createRoom(model));
=======
            return Ok(_roomM.createRoom(model));
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/RoomController.cs
        }

        [HttpGet]
        [Route("api/RoomBooking/checkRoom/{id}/{date}")]
        public IHttpActionResult makeARoom(int id,DateTime date)
        {
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/RoomController.cs
            return Ok(_rManager.checkRoomAvailability(id,date));
=======
            return Ok(_roomM.checkRoomAvailability(id,date));
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/RoomController.cs
        }

        [HttpPost]
        [Route("api/RoomBooking/bookRoom")]
        public IHttpActionResult bookARoom([FromBody]Booking model)
        {
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/RoomController.cs
            return Ok(_rManager.bookRoom(model));
=======
            return Ok(_roomM.bookRoom(model));
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/RoomController.cs
        }
    }
}

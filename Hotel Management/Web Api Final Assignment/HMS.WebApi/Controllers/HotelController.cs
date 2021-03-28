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
    public class HotelController : ApiController
    {
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/HotelController.cs
        private readonly IHotelManager _hManager;
        public HotelController(IHotelManager hManager)
        {
            _hManager = hManager;   
=======
        private readonly IHotelManager _hotelM;
        public HotelController(IHotelManager hotelM)
        {
            _hotelM= hotelM;   
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/HotelController.cs
        }

        [HttpGet]
        [Route("api/Hotel/AllHotels")]
        public IHttpActionResult Hotels()
        {
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/HotelController.cs
            return Ok(_hManager.getAllHolels());
        }

        [HttpGet]
        [Route("api/Hotel/name")]
=======
            return Ok(_hotelM.getAllHolels());
        }

        [HttpGet]
        [Route("api/hotel/getHotel/name")]
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/HotelController.cs
        public string names(string name)
        {
            return name;
        }

        [HttpGet]
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/HotelController.cs
        [Route("api/Hotel/findHotel/{id}")]
        public IHttpActionResult Hotel(int id)
        {
            return Ok(_hManager.getHotel(id));
=======
        [Route("api/hotel/getHotel/{id}")]
        public IHttpActionResult Hotel(int id)
        {
            return Ok(_hotelM.getHotel(id));
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/HotelController.cs
        }

        [HttpPost]
        [Route("api/Hotel/createHotel")]
        public IHttpActionResult makeAhotel([FromBody]Hotel model)
        {
<<<<<<< HEAD:Hotel Management/Web Api Final Assignment/HMS.WebApi/Controllers/HotelController.cs
            return Ok(_hManager.createHotel(model));
=======
            return Ok(_hotelM.createHotel(model));
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812:Hotel Management/Hotel Management/Controllers/HotelController.cs
        }

    }
}

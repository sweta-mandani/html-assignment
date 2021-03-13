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
        private readonly IHotelManager _hotelM;
        public HotelController(IHotelManager hotelM)
        {
            _hotelM= hotelM;   
        }

        [HttpGet]
        [Route("api/hotel/AllHotels")]
        public IHttpActionResult Hotels()
        {
            return Ok(_hotelM.getAllHolels());
        }

        [HttpGet]
        [Route("api/hotel/getHotel/name")]
        public string names(string name)
        {
            return name;
        }

        [HttpGet]
        [Route("api/hotel/getHotel/{id}")]
        public IHttpActionResult Hotel(int id)
        {
            return Ok(_hotelM.getHotel(id));
        }

        [HttpPost]
        [Route("api/hotel/createHotel")]
        public IHttpActionResult makeAhotel([FromBody]Hotel model)
        {
            return Ok(_hotelM.createHotel(model));
        }

    }
}

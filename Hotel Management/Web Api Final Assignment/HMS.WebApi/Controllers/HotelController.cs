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
        private readonly IHotelManager _hManager;
        public HotelController(IHotelManager hManager)
        {
            _hManager = hManager;   
        }

        [HttpGet]
        [Route("api/Hotel/AllHotels")]
        public IHttpActionResult Hotels()
        {
            return Ok(_hManager.getAllHolels());
        }

        [HttpGet]
        [Route("api/Hotel/name")]
        public string names(string name)
        {
            return name;
        }

        [HttpGet]
        [Route("api/Hotel/findHotel/{id}")]
        public IHttpActionResult Hotel(int id)
        {
            return Ok(_hManager.getHotel(id));
        }

        [HttpPost]
        [Route("api/Hotel/createHotel")]
        public IHttpActionResult makeAhotel([FromBody]Hotel model)
        {
            return Ok(_hManager.createHotel(model));
        }

    }
}

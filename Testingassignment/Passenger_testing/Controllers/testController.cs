using Passenger_testing.Models;
using Passenger_testing.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Passenger_testing.Controllers
{
    public class testController : ApiController
    {
        private readonly IPassenger _passengerManager;

        public testController(IPassenger passengerManager)
        {
            _passengerManager = passengerManager;
        }

        [HttpPost]
        [Route("api/Passengers/PassengerRegistration")]
        public passe_test PassengerRegistration([FromBody] passe_test model) => _passengerManager.PassengerRegistration(model);

        [HttpPut]
        [Route("api/Passengers/PassengerUpdate")]
        public passe_test PassengerDetailsUpdate([FromBody] passe_test model)
        {

            var result = _passengerManager.PassengerUpdate(model);
            return result;
        }

        [HttpDelete]
        [Route("api/Passengers/PassengerDetailsDelete")]
        public bool PassengerDelete(String id)
        {

            bool result = _passengerManager.PassengerDelete(id);
            return result;
        }

        

        [HttpGet]
        [Route("api/Passengers/getAllPassenger")]
        public IList<passe_test> getAllPassenger()
        {
            return _passengerManager.getAllPassenger();
        }
        [HttpGet]
        [Route("api/Passengers/GetPassenger")]
        public HttpResponseMessage GetPassenger(String id)
        {
            if (id != null)
            {
                try
                {

                    var passenger = _passengerManager.getPassengerByPassengerId(id);
                    if (passenger.Firstname != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, passenger);

                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}


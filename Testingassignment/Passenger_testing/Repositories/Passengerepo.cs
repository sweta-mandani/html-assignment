
using Passenger_testing.Models;
using Passenger_testing.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLPM.DAL.Repository.Classes
{
    public class Passengerepo : IPassenger
    {
        private readonly passengerEntities _dbContext;
        public Passengerepo()
        {
            _dbContext = new passengerEntities();
        }
        public bool PassengerDelete(string Passenger_number)
        {
            try
            {
                var passenger = _dbContext.passe_test.Where(s => (Passenger_number.Equals(s.Passenger_number.ToString()))).FirstOrDefault();
                if (passenger.Firstname != null)
                {
                    _dbContext.passe_test.Remove(passenger);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public IList<passe_test> getAllPassenger()
        {
            var entities = _dbContext.passe_test.OrderBy(c => c.Firstname).ToList();
            return entities;
        }

        public passe_test getPassengerByPassengerId(string Passenger_number)
        {
            var passenger = _dbContext.passe_test.Where(s => (Passenger_number.Equals(s.Passenger_number.ToString()))).FirstOrDefault();
            return passenger;
        }

        public passe_test PassengerRegistration(passe_test model)
        {
            passe_test passenger = model;
            passenger.Passenger_number = Convert.ToInt32(DateTime.Now.Ticks.ToString());
            _dbContext.passe_test.Add(passenger);
            _dbContext.SaveChanges();

            return model;
        }

        public passe_test PassengerUpdate(passe_test model)
        {

            passe_test passenger = _dbContext.passe_test.Where(s => (model.Equals(s.Passenger_number.ToString()))).FirstOrDefault();
            _dbContext.passe_test.Attach(model);
            _dbContext.SaveChanges();
            return model;
        }
    }
}


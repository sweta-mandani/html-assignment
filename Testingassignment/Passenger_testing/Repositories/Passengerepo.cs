using Passenger_testing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Passenger_testing.Repositories
{
    public class Passengerepo:IPassenger
    {
       
            private readonly passengerEntities _dbContext;

            public Passengerepo()
            {
                _dbContext = new passengerEntities();
            }
            public Passengerepo(passengerEntities context)
            {
                _dbContext = context;
            }

           

       

             void IPassenger.Newpassenger(passe_test passenger)
            {
                _dbContext.passe_test.Add(passenger);
                Save();
            }

             void IPassenger.Updatepassenger(passe_test passenger)
            {
                _dbContext.Entry(passenger).State = EntityState.Modified;
            }

             void IPassenger.Deletepassenger(int id)
            {
                var p = _dbContext.passe_test.Find(id);
                if (p != null) _dbContext.passe_test.Remove(p);
            }

            public void Save()
            {
                _dbContext.SaveChanges();
            }

            private bool _disposed = false;

            protected virtual void Dispose(bool disposing)
            {
                if (!this._disposed)
                {
                    if (disposing)
                    {
                        _dbContext.Dispose();
                    }
                }
                this._disposed = true;
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

        

        IEnumerable<passe_test> IPassenger.Getpassenger()
        {
            return (IEnumerable<passe_test>)_dbContext.passe_test.ToList();
        }

        public Passengerepo GetpassengerById(int Passenger_number) => _dbContext.passe_test.Find(Passenger_number);
    }
    }

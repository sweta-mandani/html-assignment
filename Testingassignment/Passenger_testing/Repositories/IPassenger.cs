
using Passenger_testing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger_testing.Repositories
{
    public interface IPassenger
    {
        passe_test PassengerRegistration(passe_test model);
        passe_test PassengerUpdate(passe_test model);
        Boolean PassengerDelete(String Passenger_number);
        IList<passe_test> getAllPassenger();
        passe_test getPassengerByPassengerId(String Passenger_number);

    }
}


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
        
            IEnumerable<passe_test> Getpassenger();
            Passengerepo GetpassengerById(int Passenger_number);
            void Newpassenger(passe_test passenger);
            void Updatepassenger(passe_test passenger);
            void Deletepassenger(int id);
            void Save();
        
    }
}

using System.Collections.Generic;
using System.IO;


using Moq;
using Newtonsoft.Json;

using System;

using Xunit;
using Passenger_testing.Repositories;
using Passenger_testing.Controllers;

namespace CLPM_Test
{
    public class UnitTest1
    {
        private readonly Mock<IPassenger> mockDataRepo = new Mock<IPassenger>();
        private readonly testController _passengerController;

        public UnitTest1()
        {
            _passengerController = new testController(mockDataRepo.Object);
        }

        [Fact]
        public void Test_GetAllPassengers()
        {
            //Arrange
            var resultType = mockDataRepo.Setup(x => x.getAllPassenger()).Returns((IList<passe_test>)getPassengerList());
            //Act
            var response = _passengerController.getAllPassenger();
            //Assert
            Assert.Equal(2, response.Count);
        }

        [Fact]
        public void Test_GetUserById()
        {
            //Arrange
            var passenger = new passe_test();
            passenger.Passenger_number = Convert.ToInt32(DateTime.Now.Ticks.ToString());

            var resultType = mockDataRepo.Setup(x => x.getPassengerByPassengerId(passenger.Passenger_number.ToString())).Returns(passenger);
            //Act
            var result = _passengerController.GetPassenger(passenger.Passenger_number.ToString());
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_AddPassenger()
        {
            //Arrange
            var newpassenger = new passe_test() { Passenger_number = Convert.ToInt32(DateTime.Now.Ticks.ToString()), Firstname = "Meet", LastName = "Shah", Phonenumber = "9664560601" };
            var response = mockDataRepo.Setup(x => x.PassengerRegistration(newpassenger)).Returns(Addpassenger());
            //Act
            var result = _passengerController.PassengerRegistration(newpassenger);
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_UpdatePassenger()
        {
            //Act
            var model = JsonConvert.DeserializeObject<passe_test>(File.ReadAllText("Data/UpdatePassenger.json"));
            //Arrange
            var result = mockDataRepo.Setup(x => x.PassengerUpdate(model)).Returns(model);
            var response = _passengerController.PassengerDetailsUpdate(model);
            //Assert
            Assert.Equal(model, response);
        }

        [Fact]
        public void Test_DeletePassenger()
        {
            //Arrange
            var passenger = new Passenger();
            passenger.Passenger_number = Convert.ToInt32(DateTime.Now.Ticks.ToString());
            var resultType = mockDataRepo.Setup(x => x.PassengerDelete(passenger.Passenger_number.ToString())).Returns(true);
            //Act
            var response = _passengerController.PassengerDelete(passenger.Passenger_number.ToString());
            //Assert
            Assert.True(response);
        }

        private static IList<passe_test> getPassengerList()
        {
            IList<passe_test> passengers = new List<passe_test>()
            {
               new passe_test(){Passenger_number=Convert.ToInt32(DateTime.Now.Ticks.ToString()),Firstname="Meet",LastName="Shah",Phonenumber="9664560601"},
                new passe_test(){Passenger_number=Convert.ToInt32(DateTime.Now.Ticks.ToString()),Firstname="Meet",LastName="Shah",Phonenumber="9664560601"}
            };
            return passengers;
        }


        private static Passenger Addpassenger()
        {
            var passenger = new Passenger() { Passenger_number = Convert.ToInt32(DateTime.Now.Ticks.ToString()), Firstname = "Meet", LastName = "Shah", Phonenumber = "9664560601" };
            return passenger;
        }
    }
}

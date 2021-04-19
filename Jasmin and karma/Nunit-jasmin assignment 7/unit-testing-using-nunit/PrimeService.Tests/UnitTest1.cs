using NUnit.Framework;
using Prime.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        List<EmployeeDetails> li;


        /// <summary>
        /// test User details
        /// </summary>
        [Test]
        public void Checkdetails()
        {

            li = _primeService.AllUsers();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.id);
                Assert.IsNotNull(x.Name);
                Assert.IsNotNull(x.salary);
                Assert.IsNotNull(x.Geneder);
            }
        }

        /// <summary>
        /// login test
        /// </summary>
        [Test]
        public void TestLogin()
        {

            string x = _primeService.Login("Sweta", "1234");
            string y = _primeService.Login("", "");
            string z = _primeService.Login("Admin", "Admin");
            Assert.AreEqual("Userid or password could not be Empty.", y);
            Assert.AreEqual("Incorrect UserId or Password.", x);
            Assert.AreEqual("Welcome Admin.", z);
        }
        

        /// <summary>
        /// getdetails test
        /// </summary>
        [Test]
        public void getuserdetails()
        {

            var p = _primeService.getDetails(100);
            foreach (var x in p)
            {
                Assert.AreEqual(x.id, 100);
                Assert.AreEqual(x.Name, "Bharat");
            }

        }


        /// <summary>
        /// getsalary
        /// </summary>
        [Test]
        public void getsalary()
        {

            var p = _primeService.getsalary(100);
            foreach (var x in p)
            {
                
                Assert.AreEqual("not grater", p);
              
                Assert.AreEqual(x.id, 101);
                Assert.AreEqual(x.Name, "Bharat");
            }

        }
    }
}
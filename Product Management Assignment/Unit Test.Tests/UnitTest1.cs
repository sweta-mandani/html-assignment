using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Product_Management.Controllers;
using Product_Management.Models;

namespace Unit_Test.Tests
{

    [TestClass]
    public class UnitTest1
    {


        // Registration Test Method
        [TestMethod]
        public void register()
        {
            // Arrange
            AccountController controller = new AccountController();
            // Act
            ViewResult result = controller.register() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }


        // Login Test Method
        [TestMethod]
        public void Login()
        {
            AccountController controller = new AccountController();
            // Act
            ViewResult result = controller.Login() as ViewResult;
            // Assert
            Assert.IsNotNull(result);

        }


        // AddProduct Test Method

        [TestMethod]
        public void AddProduct()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.AddProduct() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        
    }
}

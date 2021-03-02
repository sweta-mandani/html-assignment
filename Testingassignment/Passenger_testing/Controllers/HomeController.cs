using Passenger_testing.Models;
using Passenger_testing.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Passenger_testing.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPassenger _PassengerRepository;

        public HomeController()
        {
            _PassengerRepository = new Passengerepo(new passengerEntities());
        }

        public HomeController(IPassenger PassengerRepository)
        {
            _PassengerRepository = PassengerRepository;
        }

        public ActionResult Index()
        {
            var employee = _PassengerRepository.Getpassenger();
            return View(employee);
        }

        public ActionResult Details(int id)
        {
            var employee = _PassengerRepository.GetpassengerById(id);
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(passe_test passenger)
        {
            if (ModelState.IsValid)
            {
                _PassengerRepository.Newpassenger(passenger);
                _PassengerRepository.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = _PassengerRepository.GetpassengerById(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(passe_test passenger)
        {
            if (ModelState.IsValid)
            {
                _PassengerRepository.Updatepassenger(passenger);
                _PassengerRepository.Save();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(passenger);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = _PassengerRepository.GetpassengerById(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            _PassengerRepository.Deletepassenger(id);
            _PassengerRepository.Save();
            return RedirectToAction("Index", "Home");
        }
    }
}  
    
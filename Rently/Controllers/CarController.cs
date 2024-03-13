using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rently.Models;
using Rently.ViewModels;
using System.Data.Entity;

namespace Rently.Controllers
{
    public class CarController : Controller
    {
        private ApplicationDbContext _context;
        public CarController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            if(User.IsInRole(RoleName.ManagerCars))
            return View("List");

            return View("ReadOnlyList");

        }

        public ActionResult Details(int id)
        {
            var car = _context.Cars.Include(type => type.CarType).SingleOrDefault(carId => carId.Id == id);
            if (car == null)
                return HttpNotFound();

            return View(car);
        }

        [Authorize(Roles = RoleName.ManagerCars)]
        public ActionResult New()
        {
            var carTypes = _context.CarTypes.ToList();

            var viewModel = new CarFormViewModel
            {
                CarType = carTypes
            };

            return View("CarForm", viewModel);
        }

        [Authorize(Roles = RoleName.ManagerCars)]
        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            var viewModel = new CarFormViewModel(car)
            {
                CarType = _context.CarTypes.ToList()
            };

            return View("CarForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.ManagerCars)]
        public ActionResult Save(Car car)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new CarFormViewModel(car)
                {
                    CarType = _context.CarTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            if (car.Id == 0)
            {
                car.DateAdded = DateTime.Now;
                _context.Cars.Add(car);
            }
                
            else

            {
                var carInDb = _context.Cars.Single(c => c.Id == car.Id);

                carInDb.Name = car.Name;
                carInDb.ReleaseDate = car.ReleaseDate;
                carInDb.CarTypeId = car.CarTypeId;
                carInDb.NumberInStock = car.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Car");
        }


    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rently.Models;
using Rently.App_Start;
using Rently.DTOs;
using AutoMapper;
using System.Data.Entity;

namespace Rently.Controllers.API
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/cars
        public IHttpActionResult GetCars()
        { 
            var carDTO = _context.Cars
                .Include(c => c.CarType)
                .ToList()
                .Select(Mapper.Map<Car, CarDTO>);

            return Ok(carDTO);
        }

        //GET /api/cars/1
        public IHttpActionResult GetCar(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return NotFound();

            return Ok(Mapper.Map<Car, CarDTO>(car));
        }

        //POST /api/cars
        [HttpPost]
        [Authorize(Roles = RoleName.ManagerCars)]
        public IHttpActionResult CreateCar(CarDTO carDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var car = Mapper.Map<CarDTO, Car>(carDTO);

            _context.Cars.Add(car);
            _context.SaveChanges();

            carDTO.Id = car.Id;

            return Created(new Uri(Request.RequestUri + "/" + car.Id), carDTO);

        }

        //PUT /api/cars/1
        [HttpPut]
        [Authorize(Roles = RoleName.ManagerCars)]
        public IHttpActionResult UpdateCar(int id, CarDTO carDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var carInDb = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (carInDb == null)
            {
                return NotFound();
            }

            Mapper.Map<CarDTO, Car>(carDTO, carInDb);

            _context.SaveChanges();

            return Ok();
        }

        //DELETE /api/cars/1
        [HttpDelete]
        [Authorize(Roles = RoleName.ManagerCars)]
        public IHttpActionResult DeleteCar(int id)
        {
            var carInDb = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (carInDb == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(carInDb);
            _context.SaveChanges();

            return Ok();
        }


    }
}

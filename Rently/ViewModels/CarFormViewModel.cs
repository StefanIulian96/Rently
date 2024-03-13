using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rently.Models;
using System.ComponentModel.DataAnnotations;

namespace Rently.ViewModels
{
    public class CarFormViewModel
    {

        public IEnumerable<CarType> CarType { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter the car's name.")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter the car's release date.")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Car Type")]
        [Required(ErrorMessage = "Please select the membership type.")]
        public byte? CarTypeId { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1, 50)]
        public byte? NumberInStock { get; set; }

        public string Title
        {
           get
            {
                return Id != 0 ? "Edit Car" : "New Car";
            }
        }

        public CarFormViewModel()
        {
            Id = 0;
        }

        public CarFormViewModel(Car car)
        {
            Id = car.Id;
            Name = car.Name;
            ReleaseDate = car.ReleaseDate;
            NumberInStock = car.NumberInStock;
            CarTypeId = car.CarTypeId;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Rently.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the car's name.")]
        public string Name { get; set; }

        public CarType CarType { get; set; }

        [Display(Name = "Car Type")]
        [Required(ErrorMessage = "Please select the membership type.")]
        public byte CarTypeId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1, 50)]
        public byte NumberInStock { get; set; }

    }


}
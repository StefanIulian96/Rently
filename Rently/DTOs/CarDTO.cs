using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Rently.Models;

namespace Rently.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte CarTypeId { get; set; }

        public CarTypeDTO CarType { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
    }
}
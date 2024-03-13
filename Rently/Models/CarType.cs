using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace Rently.Models
{
    public class CarType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }
    }
}
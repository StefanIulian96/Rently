using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Rently.Models;

namespace Rently.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool LoyaltyProgramSubscription { get; set; }

        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }


        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
            public int Id { get; set; }
            [Required]
            [StringLength(255)]
            public String Name { get; set; }
            [Display(Name = "Date of Birth")]

           
            public DateTime? BirthDate { get; set; }

            public bool IsSubscribeToNewsletter { get; set; }
            
            
            public byte MembershipTypeId { get; set; }
            public MembershipTypeDto MembershipType { get; set; }

        

    }
}
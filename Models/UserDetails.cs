using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MIS4200Team8.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace MIS4200Team8.Models
{
    public class UserDetail

    {
        public Guid ID { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [Display(Name = "Primary Phone")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }

        [Required]
        [Display(Name = "Current Position")]
        public string Position { get; set; }

        [Required]
        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime hireDate { get; set; }

        

        
     }
    
 

    

}
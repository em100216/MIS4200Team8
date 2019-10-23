using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MIS4200Team8.Models;
using System.Data.Entity;


namespace MIS4200Team8.Models
{
    public class sendPoints
    {

        [Required]
        public Guid ID { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name ="Core Value")]
        public string coreValue { get; set; }
        [Required]
        [Display(Name ="Points")]
        public int points { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name="Employee Name")]
        //[Required]
        public string Name { get; set; }

        [Display(Name = "Employee Email")]
        //[Required]
        public string Email { get; set; }

        [Display(Name="Employee Mobile")]
        //[Required]
        public string Mobile { get; set; }

        [Display(Name="Employee Address")]
        //[Required]
        public string Address { get; set; }
    }
}

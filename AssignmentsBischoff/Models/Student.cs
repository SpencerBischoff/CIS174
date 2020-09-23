using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentsBischoff.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please enter first name.")]
        [StringLength(32)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name.")]
        [StringLength(32)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter a grade.")]
        [Range(0,100, ErrorMessage = "Grade must be a value between 0 and 100.")]
        public int Grade { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{   
    /***************************************************************
    * Name        : Student
    * Author      : Spencer Bischoff
    * Created     : 10/1/2020
    ***************************************************************/
    public class Student
    {
        //[Key] is here to try and resolve an error I was having. Not resolved error yet, so left it here for now.
        [Key]
        [Required(ErrorMessage = "Please enter student ID")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please enter first name of student")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name of student")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter a grade")]
        public int Grade { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

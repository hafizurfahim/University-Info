using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace University_Info.Models
{
    public class Student
    {
       [Required(ErrorMessage ="Enter Student name !!.") ,MinLength(2)]
       [Display(Name = "Student Name") ]
        public string student_name { set; get; }
        [Required(ErrorMessage = "Enter Reg no !!."), MinLength(2)]
        public string reg_no { set; get; }
        [Required]
        [EmailAddress(ErrorMessage ="Enter Email Address .!!!")]
        public string email { set; get; }
        [Required(ErrorMessage = "Enter address !!."), MinLength(2)]
        public string address{ set; get; }
        public string dept_name { set; get; }
    }
}

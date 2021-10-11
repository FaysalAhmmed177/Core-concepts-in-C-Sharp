﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please Provide Student Name"), MaxLength(4)]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public string DepartmentName { get; set; }
    }
}

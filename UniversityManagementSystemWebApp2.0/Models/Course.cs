using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemWebApp2._0.Models
{
    public class Course
    {
        public int Id { get; set; }

        //It seems that a string cannot be made unique unless a stringlength is specified
        [Required]
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 5)]
        [Index(IsUnique = true)]
        public string Code { get; set; }

        [Required]
        [Range(0.5, 5.0)]
        public double Credit { get; set; }


        public string Description { get; set; }


        public Department Department { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Semester Semester { get; set; }

        [Required]
        [Display(Name = "Semester")]
        public byte SemesterId { get; set; }
    }
}
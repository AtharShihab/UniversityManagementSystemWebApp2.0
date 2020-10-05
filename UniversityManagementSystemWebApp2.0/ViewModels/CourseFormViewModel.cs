using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UniversityManagementSystemWebApp2._0.Models;

namespace UniversityManagementSystemWebApp2._0.ViewModels
{
    public class CourseFormViewModel
    {
        public int Id { get; set; }

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
        public double? Credit { get; set; }


        public string Description { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Required]
        [Display(Name = "Semester")]
        public byte SemesterId { get; set; }

        public List<Department> Departments { get; set; }
        public List<Semester> Semesters { get; set; }

        public string ErrorMessage { get; set; }
    }
}
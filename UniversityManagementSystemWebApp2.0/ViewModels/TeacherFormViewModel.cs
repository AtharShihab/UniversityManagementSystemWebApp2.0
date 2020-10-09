using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UniversityManagementSystemWebApp2._0.Models;

namespace UniversityManagementSystemWebApp2._0.ViewModels
{
    public class TeacherFormViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        [Index(IsUnique = true)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Contact No.")]
        public string ContactNo { get; set; }

        [Required]
        [Display(Name = "Designation")]
        public int DesignationId { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Display(Name = "Credit to be taken")]
        [Required]
        [Range(0.5, 25)]
        public double? CreditToBeTaken { get; set; }

        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Designation> Designations { get; set; }

        public string ErrorMessage { get; set; }
    }
}
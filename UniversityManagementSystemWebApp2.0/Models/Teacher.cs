using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemWebApp2._0.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        [Index(IsUnique = true)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Contact No.")]
        public string ContactNo { get; set; }

        public Designation Designation { get; set; }

        [Required]
        [Display(Name = "Designation")]
        public int DesignationId { get; set; }
        public Department Department { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Display(Name = "Credit to be taken")]
        public double CreditToBeTaken { get; set; }
    }
}
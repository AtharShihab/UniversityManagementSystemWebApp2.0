using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemWebApp2._0.ViewModels
{
    public class DepartmentFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(7, ErrorMessage = "Code must between 2 to 7 character long", MinimumLength = 2)]
        public string Code { get; set; }

        public string ErrorMessage { get; set; }
    }
}
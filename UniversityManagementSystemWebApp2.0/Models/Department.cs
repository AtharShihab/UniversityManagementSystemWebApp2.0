﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemWebApp2._0.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required]
        [StringLength(7, ErrorMessage ="Code must between 2 to 7 character long", MinimumLength =2)]
        [Index(IsUnique = true)]
        public string Code { get; set; }
    }
}
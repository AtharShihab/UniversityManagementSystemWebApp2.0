using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystemWebApp2._0.Models;

namespace UniversityManagementSystemWebApp2._0.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            var departments = new List<Department>
            {
                new Department {
                    Id = 1,
                    Name = "Computer Science & Engineering",
                    Code = "CSE"
                },
                new Department
                {
                    Id = 2,
                    Name = "Electrical & Electronics Engineering",
                    Code = "EEE"
                },
                new Department
                {
                    Id = 3,
                    Name = "Mathemetics",
                    Code = "MATH"
                },
                new Department
                {
                    Id = 4,
                    Name = "Physics",
                    Code = "PHY"
                }
            };
            return View(departments);
        }


        
        public ActionResult New()
        {
            return View();
        }
    }
}
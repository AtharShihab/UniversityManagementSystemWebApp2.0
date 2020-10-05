using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystemWebApp2._0.Models;
using UniversityManagementSystemWebApp2._0.ViewModels;

namespace UniversityManagementSystemWebApp2._0.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Departments
        public ActionResult Index()
        {
            var departments = _context.Departments.ToList();

            return View(departments);
        }


        
        public ActionResult New()
        {
            var viewModel = new DepartmentFormViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Department department)
        {
            if (!ModelState.IsValid)
            {
                return View("New", department);
            }


            //IsUnique Check
            var departments = _context.Departments.Where(d => d.Code == department.Code || d.Name == department.Name).ToList();
            if (departments.Count != 0)
            {
                var viewModel = new DepartmentFormViewModel
                {
                    Code = department.Code,
                    Name = department.Name,
                    ErrorMessage = "Department Name & Code must be Unique"
                };
                
                return View("New", viewModel);
            }
            //IsUnique Check end




            _context.Departments.Add(department);
            _context.SaveChanges();

            return RedirectToAction("Index", "Departments");
        }
    }
}
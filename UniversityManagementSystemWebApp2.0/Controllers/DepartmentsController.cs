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
        private ApplicationDbContext _context;

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
            return View();
        }

        [HttpPost]
        public ActionResult Save(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();


            return RedirectToAction("Index", "Departments");
        }
    }
}
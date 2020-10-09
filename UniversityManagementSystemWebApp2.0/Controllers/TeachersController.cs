using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystemWebApp2._0.Models;
using UniversityManagementSystemWebApp2._0.ViewModels;

namespace UniversityManagementSystemWebApp2._0.Controllers
{
    public class TeachersController : Controller
    {
        private ApplicationDbContext _context;

        public TeachersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Teachers
        public ActionResult Index()
        {
            var teachers = _context.Teachers.Include(t => t.Department).ToList();
            return View(teachers);
        }


        public ActionResult New()
        {
            var viewModel = new TeacherFormViewModel
            {
                Designations = _context.Designations.ToList(),
                Departments = _context.Departments.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new TeacherFormViewModel
                {
                    Name = teacher.Name,
                    Address = teacher.Address,
                    Email = teacher.Email,
                    ContactNo = teacher.ContactNo,
                    DepartmentId = teacher.DepartmentId,
                    DesignationId = teacher.DesignationId,
                    Designations = _context.Designations.ToList(),
                    Departments = _context.Departments.ToList(),
                    CreditToBeTaken = teacher.CreditToBeTaken
                };

                return View("New", viewModel);
            }


            //IsUnique Cheack
            var teachers = _context.Teachers.Where(t => t.Email == teacher.Email).ToList();
            if (teachers.Count != 0)
            {
                var viewModel = new TeacherFormViewModel
                {
                    Name = teacher.Name,
                    Address = teacher.Address,
                    Email = teacher.Email,
                    ContactNo = teacher.ContactNo,
                    DepartmentId = teacher.DepartmentId,
                    DesignationId = teacher.DesignationId,
                    Designations = _context.Designations.ToList(),
                    Departments = _context.Departments.ToList(),
                    CreditToBeTaken = teacher.CreditToBeTaken,
                    ErrorMessage = "This email address has already been taken"
                };

                return View("New", viewModel);
            }
            //IsUnique Check end



            _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Teachers");
        }

    }
}
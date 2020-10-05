using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystemWebApp2._0.Models;
using UniversityManagementSystemWebApp2._0.ViewModels;

namespace UniversityManagementSystemWebApp2._0.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            var viewModel = new CourseFormViewModel
            {
                Semesters = _context.Semesters.ToList(),
                Departments = _context.Departments.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Save(Course course)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CourseFormViewModel
                {
                    Code = course.Code,
                    Name = course.Name,
                    Credit = course.Credit,
                    Description = course.Description,
                    DepartmentId = course.DepartmentId,
                    SemesterId = course.SemesterId,
                    Departments = _context.Departments.ToList(),
                    Semesters = _context.Semesters.ToList()
                };

                return View("New", viewModel);
            }


            //IsUnique Cheack
            var courses = _context.Courses.Where(c => c.Code == course.Code || c.Name == course.Name).ToList();
            if (courses.Count != 0)
            {
                var viewModel = new CourseFormViewModel
                {
                    Code = course.Code,
                    Name = course.Name,
                    Credit = course.Credit,
                    Description = course.Description,
                    DepartmentId = course.DepartmentId,
                    SemesterId = course.SemesterId,
                    Departments = _context.Departments.ToList(),
                    Semesters = _context.Semesters.ToList(),
                    ErrorMessage = "Course Name & Code must be Unique"
                };

                return View("New", viewModel);
            }
            //IsUnique Check end



            _context.Courses.Add(course);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
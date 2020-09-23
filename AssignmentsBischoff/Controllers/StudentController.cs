using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentsBischoff.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsBischoff.Controllers
{
    public class StudentController : Controller
    {
        private StudentView context { get; set; }
        public StudentController(StudentView ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var viewModel = new StudentView[] { };

            return View(viewModel);
        }

            [HttpGet]
        public IActionResult List(int ID)
        {
            if (ID <= 2)
            {
                ViewBag.Title = "You do not have a sufficient access level to view this data.";
                return View();
            }
            else if (ID > 2 && ID < 8)
            {
                ViewBag.Title = "List of Students:";
                return View();
            }
            else
            {
                ViewBag.Title = "Hello Admin";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Index(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index", "Student");
        }
    }
}

/**************************************************************
* Name        : StudentController
* Author      : Spencer Bischoff
* Created     : 10/1/2020
* Course      : CIS 174 - Advanced C# Programming
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This project tests various aspects of stacks.
*               Input:  User input on Index page
*               Output: Index page and Partialview _StudentList
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext context { get; set; }
        public StudentController(StudentContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetId(int? id)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Students", id);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Students(int? id)
        {
            ViewBag.id = id;
            List<Student> students = context.Student.OrderBy(n => n.StudentId).ToList();
            return View("Index", id);
        }
    }
}

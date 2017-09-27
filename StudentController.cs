using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {
            Student student = new Student();
            student.id = 1;
            student.name = "Ajay Kumar";
            student.age = 24;
            student.course = "CS";
            return View(student);
        }
    }
}
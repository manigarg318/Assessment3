using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeklyAssesment1.Models;

namespace WeeklyAssesment1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> sList = new List<Student>()
        {
           new Student { Sid = 1, Sname = "Sarthak", SDob = DateTime.Parse("12/12/1998"), Scont = "7856484245" },
                 new Student { Sid = 2, Sname = "Sarthak1", SDob = DateTime.Parse("12/12/1999"), Scont = "7856484245" },
                  new Student { Sid = 3, Sname = "Sarthak2", SDob = DateTime.Parse("12/12/1996"), Scont = "7856484245" },
                   new Student { Sid = 4, Sname = "Sarthak3", SDob = DateTime.Parse("12/12/1995"), Scont = "7856484245" }

        };
        public IActionResult Display()
        {
            ViewBag.NOS = sList.Count;
            return View(sList);
        }
    }
}

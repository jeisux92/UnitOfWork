using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DL.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using UnitOfWork.Models;

namespace UnitOfWork.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IStudentService studentService)
        {
            Student student = new Student()
            {
                StudentId = 1,
                Name = "Gabriel"
            };
            studentService.SaveUser(student);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

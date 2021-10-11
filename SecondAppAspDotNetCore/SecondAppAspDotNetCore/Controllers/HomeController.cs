using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondAppAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SecondAppAspDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult Text()
        //{
        //    return View();
        //}
        //public string Hello(string name, string address)
        //{
        //    return "I am from Hello action " + name + " " + address;
        //}
        public string Admission(Student student)
        {
            return "Name "+student.Name+" Address: "+student.Address+" Email: "+student.Email+" Father name: "+student.FatherName;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Practise.Core.Models;
using Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        public IActionResult Index()
        {
            var emplist = employeeService.GetEmployeeList();
            return View(emplist);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(Employee model)
        {
            employeeService.CreateEmployee(model);
            return RedirectToAction(nameof(Index));
        }
    }
}

using EmployeeSys.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSys.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(EmployeeData.Employees);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            EmployeeViewModel model = new EmployeeViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeData.Employees.Add(model);
            }
            return RedirectToAction("Index");
        }
    }
}

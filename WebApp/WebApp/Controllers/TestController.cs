using System;
using WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<Employees> employeeList = new List<Employees>();
            Employees emp = new Employees();
            employeeList.Add(new Employees { EmployeeID = 4, Name = "Nimmi", Department = "IT" });
            employeeList.Add(new Employees { EmployeeID = 5, Name = "John", Department = "Sales" });
            employeeList.Add(new Employees { EmployeeID = 6, Name = "Sara", Department = "Accountant" });

            // ViewBag.EmployeeList = employeeList;
            ViewData["EmployeeList"] = employeeList;
            ViewBag.Employeename = "Sara";
            ViewData["Employeename"] = "John";
            TempData["EmployeeName"] = "Nimmi";

            return View();
        }
        public ActionResult SecondPage()
        {
            return View();
        }

    }
}
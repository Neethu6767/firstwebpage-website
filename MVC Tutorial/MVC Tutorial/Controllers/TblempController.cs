using System;
using MVCTutorial.models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class TblempController : Controller
    {
        // GET: Tblemp
        public ActionResult Index1()
        {
            List<Employees> employeeList = new List<Employees>();
=            return View();
        }
    }
}
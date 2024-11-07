using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class NewController : Controller
    {
        
        public ActionResult Index()
        {
            Online_businessEntities db = new Online_businessEntities();
            Employee em = db.Employees.SingleOrDefault(x => x.EmployeeID == 1);
            EmployeeViewModel empmodel = new EmployeeViewModel();
            empmodel.EmployeeID = em.EmployeeID;
            empmodel.Name = em.Name;
            


            return View(empmodel);
        }
    }
}
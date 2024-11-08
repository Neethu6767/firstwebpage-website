using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDwithEF.Models;
using System.Net;

namespace CRUDwithEF.Controllers
{
    public class EmpDetailController : Controller
    {
        private CRUDwithEFEntities2 db = new CRUDwithEFEntities2();
        // GET: Employees
        public ActionResult Index()
        {
            return View(from empDetail in db.EmpDetails.Take(3) select empDetail);
        }
        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]

        public ActionResult Create([Bind(Include = "ID,EMPcode,EMPname,Designation,Salary")] EmpDetail employee)
        {
            if (ModelState.IsValid)
            {
                db.EmpDetails.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }



    }
}
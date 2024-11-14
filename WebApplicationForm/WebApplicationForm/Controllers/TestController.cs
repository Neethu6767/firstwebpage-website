using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForm.Models;
using System.Data;
using System.Data.SqlClient;


namespace WebApplicationForm.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
     public ActionResult Index()
      {
        IMSEntities db = new IMSEntities();

          List<Branch> list = db.Branches.ToList();
         ViewBag.Blist = new SelectList(list, "BranchId", "Branchname");
          return View();

      }
        [HttpPost]
        public ActionResult Index(Employee model)
        {
            IMSEntities db = new IMSEntities();


          List<Branch> list = db.Branches.ToList();
          ViewBag.Blist = new SelectList(list, "BranchId", "Branchname");

            Employee emp = new Employee();
            emp.Address = model.Address;
            emp.Name = model.Name;
            emp.DeptId = model.DeptId;
            db.Employees.Add(emp);
            db.SaveChanges();
            int latestEmpid = emp.EmployeeID;
            Site site = new Site();
            site.Sitename = model.SiteName;
            site.Employeeid = latestEmpid;
            db.Sites.Add(site);
            db.SaveChanges();




            return View(model);
        }
    }
}
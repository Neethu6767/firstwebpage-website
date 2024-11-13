
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudOperation.Models;

using System.Data.Entity;
using System.Data.SqlClient;

namespace CrudOperation.Controllers
{
    public class HomeController : Controller
    {
        CRUDwithEFEntities db = new CRUDwithEFEntities();
        public ActionResult Index()
        {

            var departments = db.tbl_Dept.ToList();
            var departmentList = departments.Select(d => new SelectListItem
            {
                Value = d.ID.ToString(),
                Text = d.DepartmentName
            }).ToList();

            ViewBag.DepartmentList = departmentList;


            //ViewBag.Departments = new SelectList(departments, "Id", "DeptName");

            return View();
            return RedirectToAction("Create");
        }
        public ActionResult Create()
        {
            ViewBag.DepartmentList = new SelectList(db.tbl_Dept, "ID", "DepartmentName");
            return View();
        }
        [HttpPost]

        public ActionResult Create([Bind(Include = "Sid,Sname,Department,Addres,DeptId")] Student_Data stud, int? DepartmentSelect)
        {
            if (DepartmentSelect == null)
            {
                return RedirectToAction("Index");
            }


            var department = db.tbl_Dept.FirstOrDefault(d => d.ID == DepartmentSelect);
            if (department == null)
            {
                return HttpNotFound();
            }

            stud.DeptId = department.ID;

            // Set ViewBag to display department details on the form
            ViewBag.DepartmentName = department.DepartmentName;
            ViewBag.DepartmentId = department.ID;
            ViewBag.DepartmentList = new SelectList(db.tbl_Dept, "ID", "DepartmentName", department.ID);


            if (ModelState.IsValid)
            {
                db.Student_Data.Add(stud);
                db.SaveChanges();

                return RedirectToAction("Index");
            }



            //var student = new Student_Data { DeptId = department.ID };

            return View(stud);
        }

    }
}



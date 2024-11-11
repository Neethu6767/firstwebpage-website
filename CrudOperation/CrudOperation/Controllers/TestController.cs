using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudOperation.Models;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Net;

namespace CrudOperation.Controllers
{
    public class TestController : Controller
    {
        CRUDwithEFEntities db = new CRUDwithEFEntities();
        // GET: Test
        public ActionResult Index()
        {
           // CRUDwithEFEntities db = new CRUDwithEFEntities();
            return View(from EmpDetail in db.EmpDetails.Take(5)
                        select EmpDetail);
        }
        public ActionResult Create()
        {
            return View();
        }
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
        public ActionResult Edit(int id)
        {
            var employee = db.EmpDetails.FirstOrDefault(e => e.ID == id);
            if (employee == null)
            {
                return HttpNotFound(); 
            }
            return View(employee); 
        }


        [HttpPost]
        public ActionResult Edit(EmpDetail model)
        {
            if (ModelState.IsValid)
            {
                var employee = db.EmpDetails.Find(model.ID);
                if (employee != null)
                {
                    employee.ID = model.ID;
                    employee.EMPcode = model.EMPcode;
                    employee.EMPname = model.EMPname;
                    employee.Designation = model.Designation;
                    employee.Salary = model.Salary;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            // If there's an error, return the view with the model
          ViewBag.ID = new SelectList(db.EmpDetails.ToList(), "ID", "EMPcode", model.ID);
            return View(model);
        }
      
        public ActionResult Delete(EmpDetail model)
        {
            if (ModelState.IsValid)
            {
                var employee = db.EmpDetails.Find(model.ID);
                if (employee != null)
                {
                    employee.ID = model.ID;
                    employee.EMPcode = model.EMPcode;
                    employee.EMPname = model.EMPname;
                    employee.Designation = model.Designation;
                    employee.Salary = model.Salary;
                    db.EmpDetails.Remove(employee);

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
         
            return View(model);
        }

        



    }


    }

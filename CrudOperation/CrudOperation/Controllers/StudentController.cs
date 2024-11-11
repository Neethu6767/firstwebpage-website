using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudOperation.Models;
using System.Data.SqlClient;
using System.Data.Entity;

namespace CrudOperation.Controllers
{
   
    public class StudentController : Controller
    {
        CRUDwithEFEntities db = new CRUDwithEFEntities();
        public ActionResult Index()
        {
            
            var students = db.Student_Data
                             .Where(s => s.Sname.StartsWith("A"))
                             .ToList(); 

            return View(students);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Sid,Sname,Department,Addres")] Student_Data student)
        {
            if (ModelState.IsValid)
            {
                db.Student_Data.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }
        public ActionResult Edit(int id)
        {
            var student = db.Student_Data.FirstOrDefault(s => s.Sid == id);
            if(student==null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(student);
            }

        }
        [HttpPost]
        public ActionResult Edit(Student_Data studentmodel)
            {
            var stu = db.Student_Data.Find(studentmodel.Sid);
                if(studentmodel != null)
            {

                stu.Sid = studentmodel.Sid;
                stu.Sname = studentmodel.Sname;
                stu.Department = studentmodel.Department;
                stu.Addres = studentmodel.Addres;
                db.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(studentmodel);
        }
        public ActionResult Delete(Student_Data studentmodel)
        {
            if (ModelState.IsValid)
            {
                var student = db.Student_Data.Find(studentmodel.Sid);
                if (student != null)
                {
                    student.Sid = studentmodel.Sid;

                    student.Sname = studentmodel.Sname;

                    student.Department = studentmodel.Department;
                    student.Addres = studentmodel.Addres;
                    
                    db.Student_Data.Remove(student);

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(studentmodel);
        }

    }

}

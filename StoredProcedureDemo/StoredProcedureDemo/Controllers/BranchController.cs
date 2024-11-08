using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoredProcedureDemo.Models;

namespace StoredProcedureDemo.Controllers
{
    
    public class BranchController : Controller
    {
        IMSEntities db = new IMSEntities();
        // GET: Branch
        public ActionResult Index()
        {
            return View(db.sp_select_branch().ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Branch o)
        {
            db.sp_insert_branch(o.BranchId, o.Branchname);
            return View();
        }
        public ActionResult Edit(int id)
        {
            var s = db.sp_find_branch(id).FirstOrDefault();
            return View(s);
        }
    }
}
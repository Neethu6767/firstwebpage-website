using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using ClientSideValidation.Models;

namespace ClientSideValidation.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index(Employee model)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index"); 
            }

            return View(model);
        }
    }
}
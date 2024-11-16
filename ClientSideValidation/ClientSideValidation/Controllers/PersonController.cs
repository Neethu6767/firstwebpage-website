using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientSideValidation.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ClientSideValidation.Controllers
{
    public class PersonController : Controller
    {
        Online_businessEntities db = new Online_businessEntities();
        // GET: Person
        public ActionResult Index()
        {
            var personlist = db.tblPersons.ToList();
            return View(personlist);
        }
        public JsonResult GetAll()
        {
            var personlist = db.tblPersons.ToList();
          //  var jsn = JsonConvert.SerializeObject(personlist);
            return Json(personlist, JsonRequestBehavior.AllowGet);

        }
    }
}
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
        [HttpPost]
        public JsonResult Addperson(string PersonName, int PhoneNumber, string PersonType, string Details)
        {
            tblPerson newone = new tblPerson
            {
                PersonName = PersonName,
                PhoneNumber = PhoneNumber,
                PersonType = PersonType,
                Details = Details
            };
            db.tblPersons.Add(newone);
            db.SaveChanges();

            return Json(new { success = true, message = "Person added successfully." });
        


    }
        [HttpPost]
        public JsonResult UpdatePerson(int Slno, string PersonName, int PhoneNumber, string PersonType, string Details)
        {
            var person = db.tblPersons.FirstOrDefault(p => p.Slno == Slno);
            if (person != null)
            {
                person.PersonName = PersonName;
                person.PhoneNumber = PhoneNumber;
                person.PersonType = PersonType;
                person.Details = Details;

                db.SaveChanges();
                return Json(new { success = true, message = "Person updated successfully." });
            }

            return Json(new { success = false, message = "Person not found." });
        }

        [HttpPost]
        public JsonResult DeletePerson(int Slno)
        {
            var person = db.tblPersons.FirstOrDefault(p => p.Slno == Slno);
            if (person != null)
            {
                db.tblPersons.Remove(person);
                db.SaveChanges();
                return Json(new { success = true, message = "Person deleted successfully." });
            }

            return Json(new { success = false, message = "Person not found." });
        }
    }


}
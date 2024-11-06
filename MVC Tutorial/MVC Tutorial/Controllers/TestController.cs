using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Name = "Neethu";
            List<string> list = new List<string>();
            list.Add("Neethu");
            list.Add("Ammu");
            list.Add("Appu");
            list.Add("Bincy");
            ViewBag.NameList = list;

            return View();
        }
    }
}
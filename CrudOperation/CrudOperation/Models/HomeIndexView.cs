using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperation.Models
{
    public class HomeIndexView
    {
        public int SelectedID { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
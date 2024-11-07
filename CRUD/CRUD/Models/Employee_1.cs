using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRUD.Models
{
    public class Employee_1
    {

        public int Id { get; set; }

        
        public int EmployeeCode { get; set; }

  
        public string EmployeeName { get; set; }

     
        public string Designation { get; set; }

  
        public decimal Salary { get; set; }
    }
}
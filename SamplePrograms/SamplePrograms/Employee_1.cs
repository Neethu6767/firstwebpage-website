using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    class Employee_1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }

       
        public Employee_1(string firstName, string lastName, string gender, decimal salary, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Salary = salary;
            DateOfBirth = dateOfBirth;
        }

      
        public string DisplayFullName()
        {
            return $"{FirstName} {LastName}";
        }

       
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Full Name: {DisplayFullName()}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Date of Birth: {DateOfBirth:yyyy-MM-dd}");
            Console.WriteLine();
        }
    }
    class EmployeeData_1
    {
        static void Main(string[] args)
        {
            
            Employee_1 emp1 = new Employee_1("Anu","Sarath",  "Female", 50000m, new DateTime(1990, 5, 15));
            Employee_1 emp2 = new Employee_1("Bincy", "Lekshmi", "Female", 60000m, new DateTime(1985, 8, 25));
            Employee_1 emp3 = new Employee_1("Sam",  "Sun","Male", 55000m, new DateTime(1992, 12, 30));

         
            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
            emp3.DisplayEmployeeDetails();
            Console.ReadKey();
                
        }
        }

}


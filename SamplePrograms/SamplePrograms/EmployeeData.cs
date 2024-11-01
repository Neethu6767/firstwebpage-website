using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    class Employee

    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Employee(int empId, string name)
        {
            Id = empId;
            Name = name;
        }
        




    }
    class EmployeeData
    {





        static void Main(string[] args)
        {

            Dictionary<int,Employee> empDictionary = new Dictionary<int,Employee>();

            Employee emp = new Employee(1, "Anu");
            Employee emp1 = new Employee(2, "veena");
            Employee emp2 = new Employee(3, "anju");
            Employee emp3 = new Employee(4, "meenu");
            Employee emp4 = new Employee(5, "neenu");

            empDictionary.Add(emp.Id, emp);
            empDictionary.Add(emp1.Id, emp1);
            empDictionary.Add(emp2.Id, emp2);
            empDictionary.Add(emp3.Id, emp3);
            empDictionary.Add(emp4.Id, emp4);
         





            foreach (var employee in empDictionary.Values)
            {
                Console.WriteLine("ID: {employee.Id}, Name: {employee.Name}");
                
            }
            Console.WriteLine("Enter Employee ID");
            int sid = Convert.ToInt32(Console.ReadLine());

            if (empDictionary.ContainsKey(sid))
            {
                Console.WriteLine($"ID:{empDictionary[sid].Id},Name:{empDictionary[sid].Name}");
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.WriteLine("Enter Employee ID to be updated");
             sid = Convert.ToInt32(Console.ReadLine());
            if (empDictionary.ContainsKey(sid))
            {
                string upname = empDictionary[sid].Name;
                empDictionary[sid].Name = "Achu";
                Console.WriteLine($"Updated employee ID {upname} to new name: {empDictionary[sid].Name}");
            }
            int removeId = 3;
            if (empDictionary.Remove(removeId))
            {
                Console.WriteLine($"Employee with ID {removeId} has been removed.");
            }
            else
            {
                Console.WriteLine($"Employee with ID {removeId} not found.");
            }
            Console.ReadKey();


        }
    }

    }
    




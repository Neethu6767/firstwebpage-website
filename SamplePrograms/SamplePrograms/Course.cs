using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public decimal Fees { get; set; }
        public DateTime StartDate { get; set; }

        public Course(string name, int duration, decimal fees, DateTime startdate)
        {
            Name = name;
            Duration = duration;
            Fees = fees;
            StartDate = startdate;

        }
    }
        class TestCourse
        {
            static void main(string[] args)
            {
                List<Course> listcourse = new List<Course>
                {
                   new Course("Math 101", 2, 300, new DateTime(2024, 1, 15)),
                    new Course("Science 102", 3, 400, new DateTime(2024, 2, 16)),
                     new Course("Hindi 103", 1, 350, new DateTime(2024, 5, 15)),
                      new Course("Computer 103", 3, 600, new DateTime(2024, 3, 15))


                };
                var shortCourses = listcourse.Where(c => c.Duration < 3).ToList();
                var coursenames = shortCourses.Select(c => c.Name).ToList();
                Console.WriteLine("Course name with lessthan 3 months");
                foreach(var coursename in coursenames)

                    {
                    Console.WriteLine(coursename);
                }
                var shortedcoursesname = coursenames.OrderBy(name => name).ToList();
                Console.WriteLine("\n Sorted course List are");
                foreach(var sortedlist in shortedcoursesname)
                {
                    Console.WriteLine(sortedlist);

                }
                var totfee = listcourse.Sum(c => c.Fees);
                Console.WriteLine("\nTotal fees: {totfee:c}");

                Console.ReadLine();


            }
        }

    }


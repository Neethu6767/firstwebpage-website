using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SamplePrograms
{
    public class InvalidException : Exception
    {
        public InvalidException(string message) : base(message) { }




    }


        public class User
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Mobile { get; set; }
            public User(int userId, string name, string email, string mobile)
            {
                UserId = userId;
                Name = name;
                Email = email;
                Mobile = mobile;

                Validate();

            }
            private void Validate()
            {
                if (!IsValidEmail(Email))
                {
                    throw new InvalidException("Invalid email format.");
                }

                if (!IsValidMobile(Mobile))
                {
                    throw new InvalidException("Invalid mobile number format.");
                }

            }
            private bool IsValidEmail(string email)
            {

                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            private bool IsValidMobile(string mobile)
            {

                var mobilePattern = @"^\d{10}$";
                return Regex.IsMatch(mobile, mobilePattern);
            }
        }

        class TestUser
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter User ID:");
                    int userId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Email:");
                    string email = Console.ReadLine();

                    Console.WriteLine("Enter Mobile:");
                    string mobile = Console.ReadLine();

                    User user = new User(userId, name, email, mobile);
                    Console.WriteLine("User created successfully!");
                }
                catch (InvalidException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: User ID must be a number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            Console.ReadLine();


            }
        }
    }



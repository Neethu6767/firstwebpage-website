using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                string input1 = Console.ReadLine();
                double number1 = double.Parse(input1);

                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();
                double number2 = double.Parse(input2);


            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter numeric values.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            Console.ReadLine();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    class Logger
    {
           
            public void Log(string className, string methodName, string errorMessage)
            {
                Console.WriteLine("[{DateTime.Now}] [Class: {className}] [Method: {methodName}] [Error: {errorMessage}]");
            }

           
            public void Log(string errorMessage)
            {
                Console.WriteLine("[{DateTime.Now}] [Error: {errorMessage}]");
            }

            
            public void Log(string className, string errorMessage)
            {
                Console.WriteLine($"[{DateTime.Now}] [Class: {className}] [Error: {errorMessage}]");
            }

            
            public void Log(string className, string methodName, DateTime dateTime, string errorMessage)
            {
                Console.WriteLine($"[{dateTime}] [Class: {className}] [Method: {methodName}] [Error: {errorMessage}]");
            }
        }

        class Loggerprogram
        {
            static void Main(string[] args)
            {
                Logger logger = new Logger();

            
                logger.Log("UserService", "CreateUser", "Failed to create user due to invalid input.");
                logger.Log("An unexpected error occurred.");
                logger.Log("ProductService", "GetProduct", "Product not found.");
                logger.Log("OrderService", "PlaceOrder", DateTime.Now, "Failed to place order due to insufficient funds.");
            Console.ReadKey();

            }

        }
    }

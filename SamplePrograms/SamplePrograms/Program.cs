
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{



    class Program
    {
        public static class CurrencyCon
        {
            private const double USDConversionRate = 0.012;
            private const double EURConversionRate = 0.011;
            private const double AUDConversionRate = 0.018;
            private const double GBPConversionRate = 0.009;
            public static double ConvertToUSD(double amountInINR)
            {
                return Convert.ToInt32(amountInINR * USDConversionRate);
            }

            public static double ConvertToEUR(double amountInINR)
            {
                return Convert.ToInt32(amountInINR * EURConversionRate);
            }

            public static double ConvertToAUD(double amountInINR)
            {
                return Convert.ToInt32(amountInINR * AUDConversionRate);
            }

            public static double ConvertToGBP(double amountInINR)
            {
                return Convert.ToInt32(amountInINR * GBPConversionRate);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Currency Converter");
            Console.WriteLine("------------------");

            Console.Write("Enter amount in Indian Rupees (INR): ");
            double amountInINR;
            while (!double.TryParse(Console.ReadLine(), out amountInINR) || amountInINR < 0)
            {
                Console.Write("Please enter a valid amount in INR: ");
            }

            Console.WriteLine($"\nConverted Amounts:");
            Console.ReadLine();
            Console.WriteLine($"US Dollars (USD): {CurrencyCon.ConvertToUSD(amountInINR):F2}");
            Console.ReadLine();
            Console.WriteLine($"Euros (EUR): {CurrencyCon.ConvertToEUR(amountInINR):F2}");
            Console.ReadLine();
            Console.WriteLine($"Australian Dollars (AUD): {CurrencyCon.ConvertToAUD(amountInINR):F2}");
            Console.ReadLine();
            Console.WriteLine($"British Pounds (GBP): {CurrencyCon.ConvertToGBP(amountInINR):F2}");
            Console.ReadLine();

        }
    }
    }



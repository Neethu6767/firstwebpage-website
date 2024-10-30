using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    
        public class BankAccount
        {
            // Constant member for bank name
            public const string bankName = "Canera Bank";

            // Static member for interest rate
            public static double rateOfInterest = 3.5;

            // Instance members
            private double minBalance;
            private double currentBalance;
            private int accNumber;

            // Constructor to initialize a bank account
            public BankAccount(int accountNumber, double initialBalance, double minimumBalance)
            {
                accNumber = accountNumber;
                currentBalance = initialBalance;
                minBalance = minimumBalance;
            }

            // Method to enter and validate the account number
            public bool ValidateAccountNumber(int enteredAccountNumber)
            {
                return accNumber == enteredAccountNumber;
            }

            // Method to check the balance
            public double GetBalance()
            {
                return currentBalance;
            }

            // Method to withdraw an amount entered by the user
            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Withdrawal amount should be greater than zero.");
                    return;
                }

                if (currentBalance - amount < minBalance)
                {
                    Console.WriteLine($"Cannot withdraw {amount}. Minimum balance of {minBalance} required.");
                }
                else
                {
                    currentBalance -= amount;
                    Console.WriteLine($"Withdrawal of {amount} successful.");
                }
                DisplayBalance();
            }

            // Method to display the balance after withdrawal
            public void DisplayBalance()
            {
                Console.WriteLine($"Current balance: {currentBalance}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
            
                BankAccount account = new BankAccount(123456, 10000, 500);

                Console.WriteLine($"Welcome to {BankAccount.bankName}!");
                Console.WriteLine($"Current Rate of Interest: {BankAccount.rateOfInterest}%");

                // Prompt user for account number and validate it
                Console.Write("Please enter your account number: ");
                int enteredAccountNumber = int.Parse(Console.ReadLine());
  

                if (account.ValidateAccountNumber(enteredAccountNumber))
                {
                    Console.WriteLine("Account validated successfully.");
                    Console.WriteLine($"Current balance:{10000}");
                Console.ReadLine();
                    
                    Console.WriteLine($"Minimum balance: {500}");
                Console.ReadLine();

                // Prompt for withdrawal amount
                Console.Write("Enter amount to withdraw: ");
                    double amountToWithdraw = double.Parse(Console.ReadLine());

                    // Perform withdrawal
                    account.Withdraw(amountToWithdraw);
                }
                else
                {
                    Console.WriteLine("Invalid account number.");
                }

                Console.WriteLine("Thank you for banking with us!");
            }
        }
    }


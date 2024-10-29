using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    class BankAccount
    {

        private const string bankName = "Canera";
        private static double rateOfInterest = 0.05;
        private double minBalance;
        private double currentBalance;
        private string accNumber;
        public BankAccount(string accNum, double initialBalance, double minBal)
        {
            accNumber = accNum;
            currentBalance = initialBalance;
            minBalance = minBal;
        }


        public void SetAccountNumber(string accNum)
        {
            accNumber = accNum;
        }
        public double CheckBalance()
        {
            return currentBalance;
        }


        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be sufficient.");
                return false;
            }
            if (currentBalance - amount < minBalance)
            {
                Console.WriteLine("Withdrawal denied. Insufficient balance to maintain minimum required balance.");
                return false;
            }
            currentBalance -= amount;
            Console.WriteLine($"Withdrawal successful. You withdrew: {amount}");
            return true;
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {currentBalance}");
        }


        public static void SetRateOfInterest(double rate)
        {
            rateOfInterest = rate;
        }


        public static double GetRateOfInterest()
        {
            return rateOfInterest;
        }
        public static void DisplayBankName()
        {
            Console.WriteLine($"Bank Name: {bankName}");
        }
    

    static void Main()
    {
        BankAccount.DisplayBankName();

        // Creating an account with an initial balance
        BankAccount account = new BankAccount("123456", 1000.0, 100.0);
        Console.WriteLine($"Initial balance: {account.CheckBalance()}");

        Console.Write("Enter amount to withdraw: ");
        if (double.TryParse(Console.ReadLine(), out double amountToWithdraw))
        {
            if (account.Withdraw(amountToWithdraw))
            {
                account.DisplayBalance(); // Display balance after withdrawal
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    class BankAccount
    {


        
        const string bankName = "Canera";
        public static double rateOfInterest = 0.05;
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




        static void Main(string[] args)
        {

            BankAccount account = new BankAccount("123456", 10000, 500);

            Console.WriteLine($"Welcome to {BankAccount.bankName}!");
            Console.WriteLine($"Current Rate of Interest: {BankAccount.rateOfInterest}%");

           

            
            
                Console.WriteLine("Account validated successfully.");
                Console.WriteLine($"Current balance:{10000}");

                Console.WriteLine($"Minimum balance: {500}");

                Console.Write("Enter amount to withdraw: ");
                double amountToWithdraw = double.Parse(Console.ReadLine());

                account.Withdraw(amountToWithdraw);
            account.DisplayBalance();
                Console.ReadKey();
            
            
           

            Console.WriteLine("Thank you for banking with us!");
        }
    }
}
    




        


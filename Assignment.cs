using ConsoleApp10;
using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a checking account
            BankAccount checkingAccount = new BankAccount(123456789, 1000);

            // Create a savings account
            BankAccount savingsAccount = new BankAccount(987654321, 5000, "Savings");

            // Deposit and withdraw from checking account
            checkingAccount.Deposit(500);
            checkingAccount.Withdraw(200);
            checkingAccount.Deposit(300, "Paycheck");
            checkingAccount.Withdraw(800, "Rent");

            // Deposit and withdraw from savings account
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(2000);
            savingsAccount.Deposit(500, "Interest");
            savingsAccount.Withdraw(1500, "Investment");
        }
    }

    public class BankAccount
    {
        private int accountNumber;
        private double balance;
        private string accountType;

        // Constructor to initialize a checking account
        public BankAccount(int accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.accountType = "Checking";
        }

        // Constructor to initialize a savings account
        public BankAccount(int accountNumber, double initialBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.accountType = accountType;
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount} into account {accountNumber}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Overloaded Deposit method with description
        public void Deposit(double amount, string description)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount} ({description}) into account {accountNumber}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount} from account {accountNumber}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }

        // Overloaded Withdraw method with description
        public void Withdraw(double amount, string description)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount} ({description}) from account {accountNumber}. New balance: ${balance}");
            }
            else
            {
                Console.ReadLine();
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }
}



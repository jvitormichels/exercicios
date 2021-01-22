using System;
using BankAccount.Entities;
using BankAccount.Entities.Exceptions;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double intialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Account acc = new Account(number, name, intialBalance, withdrawLimit);

                Console.Write("Enter amount for deposit: ");
                acc.Deposit(double.Parse(Console.ReadLine()));

                Console.Write("\nEnter amount for withdraw: ");
                acc.Witdhdraw(double.Parse(Console.ReadLine()));
            }
            catch (DomainException e)
            {
                Console.WriteLine("\nError: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nUnexpected error: " + e.Message);
            }
        }
    }
}

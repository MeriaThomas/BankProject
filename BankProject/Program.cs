using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var account = Bank.CreateAccount("test@test.com", 100, "Checking");
            //Console.WriteLine($"AccountNumber: {account.AccountNumber}, Type: {account.TypeOfAccount}, Balance: {account.Balance}, Email Address: {account.EmailAddress}");

            //var account2 = Bank.CreateAccount("test2@test.com", 150, "Savings");

            //Console.WriteLine($"AccountNumber: {account2.AccountNumber}, Type: {account2.TypeOfAccount}, Balance: {account2.Balance}, Email Address: {account2.EmailAddress}");

            Console.WriteLine("***Welcome To My Bank***");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print all accounts");
                Console.Write("5. Please select a choice from the above: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you!");
                        return;

                    case "1":
                        Console.Write("Email Address :");
                        var emailAddress = Console.ReadLine();
                        Console.Write("Type of Account :");
                        var typeOfAccount = Console.ReadLine();
                        Console.Write("Amount to deposit :");
                        var amount = Convert.ToDecimal(Console.ReadLine());

                        var account = Bank.CreateAccount(emailAddress, amount, typeOfAccount);
                        Console.WriteLine($"AccountNumber: {account.AccountNumber}, Type: {account.TypeOfAccount}, Balance: {account.Balance: C}, Email Address: {account.EmailAddress}");
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    static class Bank
    {
        private static List<Account> accounts = new List<Account>();

        public static Account CreateAccount (string emailAddress, decimal amount, AccountTypes typeOfAccount)
        {
            var account = new Account(emailAddress,typeOfAccount);
            account.Deposit(amount);
            accounts.Add(account); // Adding each account thats being created to the accounts(line 11).
            return account;


        }

        public static List<Account> GetAllAccounts()
        {
            return accounts;
        }
    }
}

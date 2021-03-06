﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public enum AccountTypes
    {
        Checking , 
        Savings
    }
    /// <summary>
    /// This class represents a bank account.
    /// Here you canm deposit/withdraw
    /// </summary>
    public class Account
    {
        #region Variables

        private static int lastAccountNumber = 0;

        #endregion
        #region Properties
        /// <summary>
        /// Email Address of the account number
        /// </summary>
        public string EmailAddress { get; set; }

        [Key]
        public int AccountNumber { get;  set; }

        public decimal Balance { get; private set; }

        public DateTime CreatedDate { get; set; }

        public AccountTypes TypeOfAccount { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

        #endregion

        #region Constructors

        public Account()
        {
          
            AccountNumber = ++lastAccountNumber;

        }
        public Account(string emailAddress) : this()
        {
            EmailAddress = emailAddress;
        }

        public Account(string emailAddress, AccountTypes typeOfAccount): this(emailAddress)
        {
            TypeOfAccount = typeOfAccount;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        /// <returns>The updated balance</returns>
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }
        

        public decimal Withdraw (decimal amount)

        {
            Balance -= amount;
            return Balance;
        }
        #endregion
    }
}

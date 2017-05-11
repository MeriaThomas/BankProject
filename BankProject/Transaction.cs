using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public enum TransactionTypes
    {
        Credit,
        Debit
    }
    public class Transaction
    {
        internal int AccountNumber;

        [Key]
        public int TransactionId { get; set; }

        public string Description { get; set; }

        public DateTime TransactionDate { get; set; }

        public TransactionTypes TransactionType { get; set; }

        public decimal Amount { get; set; }

        public int AccountNubmber { get; set; }
        
    }
}

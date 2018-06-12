using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Classes_MSBankAccount_Tutorial
{
    class BankAccount
    {
        private static int accountNumberSeed = 1000000000;

        public BankAccount(string name, decimal initialBalance)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            Owner = name;
            Balance = initialBalance;
        }

        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}

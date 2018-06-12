using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Classes_MSBankAccount_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kyle", 1000);
            Console.WriteLine("Account {0} was created for {1} with {2} initial balance.", account.Number, account.Owner, account.Balance);
            Console.ReadLine();
        }
    }
}

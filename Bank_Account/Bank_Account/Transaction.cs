using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Transaction : Account
    {
        public void TransferFunds(string AccName, string AccNo, double transferAmount)
        {
            if (transferAmount <= 0)
            {
                Console.WriteLine("Transfer amount must be positive!");
            }
            else if (transferAmount == 0)
            {
                Console.WriteLine("Invalid transfer amount");
            }

            Account fromAccount = GetAccount(AccName);
            Account toAccount = GetAccount(AccName);

            if (fromAccount.balance< transferAmount)
            {
                Console.WriteLine("Insufficient funds!");
            }

            fromAccount.Transfer(-1 * transferAmount, AccNo);
            toAccount.Transfer(transferAmount, AccName);

        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + AccName);
            Console.WriteLine("Account Number: " + AccNo);
            Console.WriteLine("Current Balance: " + Balance);
            Console.WriteLine();
        }
    }
}

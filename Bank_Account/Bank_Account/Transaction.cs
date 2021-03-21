using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Transaction 
    {
        private Account sender;
        private Account receiver;
        public double Amount { get; set; }
        public string Additional { get; set; }

        public Transaction() { }

        public Transaction(Account sender, Account receiver, double amount, string additional)
        {
            this.sender = sender;
            this.receiver = receiver;
            Additional = additional;
            Amount = amount;
        }

        public void showTransactions()
        {
            Console.WriteLine("Transaction type: " + Additional);
            if (Additional.ToLower().Equals("transfer"))
            {
                Console.WriteLine("Sender: " + sender);
                Console.WriteLine("Receiver: " + receiver);
            }
            Console.WriteLine("Amount: " + Amount);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account sadik = new Savings("sadik", "101", 6000.0f);
            Account salman = new Current("salman", "202", 4000f);
            Account saleh = new Fixed("saleh", "403", 3000f, 2017, 11);

            Account ss = new SuperSavings("salmir", "004", 100f);
            ss.Withdraw(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("kaif", "005", 1000f, 5000);
            overdraft.Transfer(ss, 1000);
            overdraft.ShowInfo();

            Customer customer = new Customer("Fahim");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeContractsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unable to build unless we installed VS extension: http://kortlink.dk/visualstudio/p684
            // Then set project -> Properties -> Code Contract (Tab) change the assemble mode to "Standard Contract Requires"
            // Also select check box - Perform Runtime contract checking

            var acc = new Account(1000);

            Console.WriteLine("Constructor succeeded");
            Console.WriteLine("current balance: " + acc.Balance);

            acc.Deposit(500);
            Console.WriteLine("Deposit succeeded");
            Console.WriteLine("current balance: " + acc.Balance);

            acc.Withdraw(1000);
            Console.WriteLine("Withdraw succeeded");
            Console.WriteLine("current balance: " + acc.Balance);
            Console.ReadKey();
        }
    }
}

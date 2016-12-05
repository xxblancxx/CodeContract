using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace CodeContractsAccount
{
    public class Account
    {

        public double Balance { get; set; }

        public Account(double balance)
        {
            //Precondition; balance cannot be less than 0, otherwise throw exception.
            Contract.Requires<ArgumentOutOfRangeException>(balance >= 0);
            // Postcondition; constructor argument value is given to object property.
            Contract.Ensures(Balance == balance);

            // Command; Assign argument value to property
            Balance = balance;

        }
        public void Deposit(double amount)
        {
            // Keep original value of balance before command is run.
            double oldBalance = Balance;

            // Precondition; deposit amount cannot be negative
            Contract.Requires<ArgumentOutOfRangeException>(amount > 0);
            // Postcondition; new balance is equal to old balance with deposited amount added.
            Contract.Ensures(Balance == (oldBalance + amount));

            // Command; Amount is added to balance.
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            // Keep original value of balance before command is run.
            double oldBalance = Balance;

            // Precondition; withdrawal amount cannot be negative
            Contract.Requires<ArgumentOutOfRangeException>(amount > 0 && amount< Balance);
            // Postcondition; new balance is equal to old balance with withdrawn amound substracted.
            Contract.Ensures(Balance == (oldBalance - amount));

            // Command: Amount is substracted from balance
            Balance -= amount;
        }
    }
}

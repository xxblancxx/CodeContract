using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeContractsAccount;

namespace CodeContractsAccountTests
{
    [TestClass]
    public class AccountTests
    {

        [TestMethod]
        public void AccountConstructorTest()
        {
            // Create new account with balance 1000
            var account = new Account(1000);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void AccountConstructorNegativeTest()
        {
            // Trying to initialize account with negative balance, should throw ArgumentOutOfRangeException
            var account = new Account(-1000);
        }

        [TestMethod]
        public void WithdrawTest()
        {
            // Create new account with balance 1000
            var account = new Account(1000);
            // Withdraw 500
            account.Withdraw(500);

            // Fail if balance is not 500, because 1000 - 500 = 500.
            if (account.Balance != 500)
            {
                Assert.Fail();
            }
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void WithdrawNegativeTest()
        {
            // Create new account with balance 1000
            var account = new Account(1000);
            // try to withdraw negative amount.
            account.Withdraw(-1000);
        }


        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void WithdrawOverdraftTest()
        {
            // Create new account with balance 1000
            var account = new Account(1000);
            // try to exceed balance with withdrawal amount.
            account.Withdraw(1500);
        }

        [TestMethod]
        public void DepositTest()
        {
            // Create new account with balance 1000
            var account = new Account(1000);
            // Deposit 500
            account.Deposit(500);

            // Fail if balance is not 1500, because 1000 + 500 = 1500.
            if (account.Balance != 1500)
            {
                Assert.Fail();
            }
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void DepositNegativeTest()
        {
            // Create new account with balance 1000
            var account = new Account(1000);
            // try to deposit negative amount.
            account.Deposit(-1000);
        }
    }
}

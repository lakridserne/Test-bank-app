using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2_Integration_Tests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests.Tests
{
    [TestClass()]
    public class MovementTests
    {
        [TestMethod()]
        public void MovementTest()
        {
            Bank bank = new Bank("124", "jons");
            Customer c1 = new Customer("Jonas", "0708871213");
            Customer c2 = new Customer("Kasper", "0705894531");


            Account account1 = new Account(bank, c1, "3434");
            Account account2 = new Account(bank, c2, "86924");

            account1.transfer(1000, account2);

            Assert.AreEqual(account1.getBalance(), -1000);
            Assert.AreEqual(account2.getBalance(), 1000);
        }
    }
}
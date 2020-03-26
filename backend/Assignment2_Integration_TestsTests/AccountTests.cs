using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2_Integration_Tests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests.Tests
{
    [TestClass()]
    public class AccountTests
    {


        [TestMethod()]
        public void transferTest()
        {
            Bank bank = new Bank("345", "Danskebank");
            Customer c1 = new Customer("jack", "123");

            Account account = new Account(bank, c1, "123");

            var expected = account.getBalance() - 1000;

            account.transfer(1000, account);

            var actual = account.getBalance();

            Assert.AreEqual(expected, actual);
        }

    
        
    }
}
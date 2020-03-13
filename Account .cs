using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_MockingAndTDD
{
  public class Account
    {
        private IBank bank;
        private ICustomer customer;
        private String number;
        private long balance = 0;
        public Account(IBank bank, ICustomer customer, String number)
        {
            this.bank = bank;
            this.customer = customer;
            this.number = number;
        }

        public IBank getBank()
        {
            return bank;

            
        }



        public ICustomer getCustomer()
        {
            return customer;
        }

        public String getNumber()
        {
            return number;
        }

        public long getBalance()
        {
            return balance;
        }

        public void transfer(long amount, Account target)
        {
            balance -= amount;
            target.balance += amount;
        }

        public void transfer(long amount, String targetNumber)
        {
            Account target = bank.getAccount(targetNumber);
            transfer(amount, target);
        }
    }
}

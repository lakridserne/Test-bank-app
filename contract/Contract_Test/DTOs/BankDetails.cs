using System;
using System.Collections.Generic;
using System.Text;

namespace Contract_Test.DTOs
{
  public  class BankDetails
    {
        private Bank Bank;
        private Customer Customer;
        private string number;
        private long balance = 0;
        private List<Movement> movements = new List<Movement>();

        public Account(Bank IBank, Customer Customer, string number)
        {
            this.Bank = IBank;
            this.Customer = Customer;
            this.number = number;
        }

        public Bank getIBank()
        {
            return Bank;
        }

        public Customer getCustomer()
        {
            return Customer;
        }

        public string getNumber()
        {
            return number;
        }

        public long getBalance()
        {
            return balance;
        }
    }
}

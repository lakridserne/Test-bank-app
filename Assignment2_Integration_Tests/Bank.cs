using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests
{
    public class Bank
    {


        private string name;
        private string cvr;
        private List<Account> accounts;
        private string account;
        private Bank bank;


        public string getCvr()
        {
            return cvr;
        }

        public void setCvr(string cvr)
        {
            this.cvr = cvr;
        }


        public Bank(String cvr, String name)
        {
            this.cvr = cvr;
            this.name = cvr;
        }

        public String getAccount(String nummber)
        {
            return account;
        }

        public List<Account> getAccounts(Customer ICustomer)
        {

            return accounts;
        }
    }

}

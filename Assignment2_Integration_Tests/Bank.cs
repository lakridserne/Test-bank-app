﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests
{
    public class Bank
    {


        private String name;
        private String cvr;
        private List<Account> accounts;
        private String account;
        private Bank bank;


        public String getCvr()
        {
            return cvr;
        }

        public void setCvr(String cvr)
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

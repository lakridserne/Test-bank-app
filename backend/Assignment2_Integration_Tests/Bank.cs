
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Assignment2_Integration_Tests
{
    public class Bank
    {


        private string name;
        private string cvr;
        private List<Account> accounts;
        private string account;
        private Bank _bank;


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

        public void CreateTables()
        {
           if (_bank == null)
            { 
                MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");
                
                MySqlCommand acmd = new MySqlCommand(@"CREATE TABEL 'bank'name VARCHAR(100) NOT NULL, cvr VARCHAR(40)", cs);
                cs.Open();
                acmd.ExecuteNonQuery();
            }
        }

        public void GetAllBanks()
        {
            MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");

            MySqlCommand acmd = new MySqlCommand(@"SELECT * FROM db_bank.bank;", cs);
            cs.Open();
            acmd.ExecuteNonQuery();

        }

        
       
    }

}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests
{
    public class Movement
    {
        private Account _withdraw;
        private Account _deposited;
        private DateTime _currentDate;
        private long _amount;


        public Movement(DateTime currentDate, long amount, Account withdraw, Account deposited)
        {
            _currentDate = currentDate;
            _amount = amount;
            _withdraw = withdraw;
            _deposited = deposited;
        }


        //INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
      //  VALUES('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

        public void CreateMovment()
        {
            MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");

            MySqlCommand acmd = new MySqlCommand(@"INSERT INTO db_bank.movement (w.account_id, d.account_id, currentDate, ammount) VALUES('2', '3', '06-07-1987', '2000')", cs);
            cs.Open();
            acmd.ExecuteNonQuery();

        }


        public void getAllMovements()
        {
            MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");

            MySqlCommand acmd = new MySqlCommand(@"SELECT *FROM db_bank.movement;");
        }


        public Account getWithdrawalAccount() { return _withdraw; }
        public Account getDepositAccount() { return _deposited; }

    }

}

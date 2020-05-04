using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests
{
    public class Account :IAccount
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

        public List<Movement> getMovements(Account withdraw)
        {
            List<Movement> returnList = new List<Movement>();
            foreach (Movement movement in movements)
            {
                if (movement.getWithdrawalAccount().Equals(withdraw))
                {
                    returnList.Add(movement);
                }
            }
            return returnList;
        }


        public void transfer(long amount, Account target)
        {
            balance -= amount;
            target.balance += amount;
            Movement movement = new Movement(DateTime.Now, amount, this, target);
            movements.Add(movement);
        }

        public void transfer(long amount, string targetNumber)
        {
            string target = Bank.getAccount(targetNumber);
            transfer(amount, target);
        }


        public void CreateAccount()
        {
            MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");

            MySqlCommand acmd = new MySqlCommand(@"INSERT INTO account (bank_id, customer_id, number, balance) VALUES('7', '11', '2000', '1000')", cs);
            cs.Open();
            acmd.ExecuteNonQuery();

        }


        public void getAllAccounts()
        {
            MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");

            MySqlCommand acmd = new MySqlCommand(@"SELECT *FROM account;");
        }

        public void UpdateAccount()
        {
            MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");

            MySqlCommand acmd = new MySqlCommand(@"update account set balance=1000 where account_id=1", cs);
            cs.Open();
            acmd.ExecuteNonQuery();

        }

        public void DeleteAccount()
        {
            MySqlConnection cs = new MySqlConnection("Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123");

            MySqlCommand acmd = new MySqlCommand(@"DELETE FROM account WHERE account_id=1;");
        }


    }
}

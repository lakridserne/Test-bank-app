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

    }
}

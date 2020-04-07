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

        public Account getWithdrawalAccount() { return _withdraw; }
        public Account getDepositAccount() { return _deposited; }

    }

}

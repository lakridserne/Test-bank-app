using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests
{
   public interface IBank
    {
        Account getAccount(String number);
        void registerAccount(Account account);
        Customer getCustomer(String number);
        void registerCustomer(Customer ICustomer);
        String getName();
    }
}

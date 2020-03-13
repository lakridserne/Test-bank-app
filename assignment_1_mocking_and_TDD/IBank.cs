using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_1_mocking_and_TDD
{
   public interface IBank
    {
        Account getAccount(String number);
        void registerAccount(Account account);
        ICustomer getCustomer(String number);
        void registerCustomer(ICustomer customer);
        String getName();
    }
}

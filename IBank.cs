using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_MockingAndTDD
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

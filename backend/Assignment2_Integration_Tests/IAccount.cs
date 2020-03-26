using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Integration_Tests
{
   public interface IAccount
    {
        void transfer(long ammount, Account target);
        void transfer(long amount, string targetNumber);
    }
}

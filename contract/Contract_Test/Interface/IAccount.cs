using System;
using System.Collections.Generic;
using System.Text;

namespace Contract_Test.Interface
{
   public interface IAccount
    {
        IBank GetBank();
        ICustomer getCustomer();
        string getNumber();
        long getBalance();
        List<IMovement> getMovements(IAccount withdraw);
        void transfer(long amount, IAccount target);
        void transfer(long amount, string targetNumber);
    }
}

    
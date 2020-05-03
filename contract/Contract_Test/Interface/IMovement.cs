using System;
using System.Collections.Generic;
using System.Text;

namespace Contract_Test.Interface
{
   public interface IMovement
    {
        IAccount getWithdrawalAccount();
        IAccount getDepositAccount();
    }
}

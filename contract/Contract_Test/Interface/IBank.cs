using System;
using System.Collections.Generic;
using System.Text;

namespace Contract_Test.Interface
{
   public interface IBank
    {
        string getCvr();
        void setCvr(string cvr);
        string getAccount(string nummber);
        List<IAccount> getAccounts(ICustomer ICustomer);
    }
}
     
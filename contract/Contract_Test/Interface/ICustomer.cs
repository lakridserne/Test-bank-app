using System;
using System.Collections.Generic;
using System.Text;

namespace Contract_Test.Interface
{
   public interface ICustomer
    {
        string getName();
        void setName(string name);
        string getCpr();
        void setCpr(string cpr);
    }
}

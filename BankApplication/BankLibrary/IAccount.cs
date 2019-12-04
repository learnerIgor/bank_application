using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public interface IAccount
    {
        //положить деньги на счет
        void Put(decimal sum);
        //взять со счета
        decimal Withdraw(decimal sum);
    }
}

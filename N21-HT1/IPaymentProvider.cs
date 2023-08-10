using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal interface IPaymentProvider
    {
        void Transfer(IDebitCard myCard, IDebitCard youCard, decimal amount)
        {
            myCard.BankBalance - amount


        }

        bool TransferInterst { get; init; }
    }
}

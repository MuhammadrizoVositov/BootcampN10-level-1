using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal class UzumPaymentProvider
    {
        public bool TransferInterst { get; init; }

        public bool Transfer(IDebitCard myCard, IDebitCard youCard, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}

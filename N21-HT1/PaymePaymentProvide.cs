using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal class PaymePaymentProvide : IPaymentProvider
    {

        public bool TransferInterst { get; init; }
        string sourceCard { get; set; }

        public bool Transfer(IDebitCard myCard, IDebitCard youCard, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}

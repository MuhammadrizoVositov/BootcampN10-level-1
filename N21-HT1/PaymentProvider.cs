using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal class PaymentProvider : IPaymentProvider
    {
        public bool TransferInterst { get; init; }

        public bool Transfer(string sourceCard, string destinationCard, decimal amount)
        {
            return true;
        }
    }
}

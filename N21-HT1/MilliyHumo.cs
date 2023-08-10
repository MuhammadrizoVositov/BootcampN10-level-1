using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal class MilliyHumo : IDebitCard
    {
        public int CardNumber { get; set; }
        public string BankName { get; set; }

        public decimal BankBalance { get; set; }
    }
}

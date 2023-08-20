using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    public interface IOrderServise
    {
        bool Order(int id, decimal debitCardBalance);
        bool Order(string orderFilterModel, decimal debitCardBalance);
    }
}

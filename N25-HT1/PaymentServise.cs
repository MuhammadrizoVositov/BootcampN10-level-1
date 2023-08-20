using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    internal class PaymentServise : IPaymentServise
    {
        public bool CheckOut(decimal amount, DebitCard debitCard)
        {
            if (debitCard.Balance >= amount)
            {
                debitCard.Balance-=amount;
                return true;
            }
            else
            {
                return false;
            }
        }


        

        //public List<IProduct> ToList()
        //{
            
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N26_HT1
{
    public class Money
    {
        public Money() { }
        public Money(decimal amount, MoneType type, Currency current)
        {
            Amount = amount;
            Type = type;
            Currency = current;
        }
        public decimal Amount { get; set; }
        public MoneType Type { get; set; }
        public Currency Currency { get; set; }

        

        public static Money operator +(Money moneyA,Money moneyB)
        {
            if(moneyA.Type == moneyB.Type)
            {
                return new Money( moneyA.Amount + moneyB.Amount, moneyA.Type, moneyA.Currency);
            }
            if (moneyA.Type == MoneType.InBalance )
            {
                return new Money(moneyA.Amount - moneyB.Amount,  moneyB.Type, moneyB.Currency);
            }
            else  
            {
                return new Money(moneyB.Amount - moneyB.Amount, moneyA.Type, moneyA.Currency);
            }
            

        }

       

        
    }
    
}

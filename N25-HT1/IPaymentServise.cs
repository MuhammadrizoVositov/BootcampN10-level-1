﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    internal interface IPaymentServise
    {
        bool CheckOut(decimal amount, DebitCard debitCard);


        //public List<IProduct> ToList()


    }
}

    


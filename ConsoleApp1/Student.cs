﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
       public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Payment { get; set; }
        public string EduType { get; set; }
        public decimal PaymentAmount { get; set;}
        public int GetAge()=> DateTime.Now.Year-BirthDay.Year;
        public string GetSHortName() => FullName.PadRight(40,' ');

        public string GetAmount()
        {
            decimal amount = Payment - PaymentAmount;
            if (amount < 0) return $"{-amount}   haqdor";
            else return $"  {amount}  qarzdor";
        }

    }
}

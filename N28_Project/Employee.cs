﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_Project
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public string Departaments { get; set; }    

        public string No { get; set; }

        public Employee()
        {

        }
    }
}

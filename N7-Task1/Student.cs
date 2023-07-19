using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N7_Task1
{
    internal class Student
    {
        
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Payment { get; set; }
        public string EduType { get; set; }

        public string GetName()
        {
            string result = FullName.PadRight(45, ' ');
            return
                result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustahkamlash
{
    internal class Student <TId,TGrade>
    {
        public TId Id { get; set; }
        public TGrade Trade { get; set;}
        public string Name { get; set; }    

        public Student(TId id, TGrade trade, string name)
        {
            Id = id;
            Trade = trade;
            Name = name;
        }
    }
}

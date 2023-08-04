using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_HT2
{
  
    {
        public class ClassroomAttendance
        {
            protected Dictionary<string, string> students = new Dictionary<string, string>();
            public void Mark(string fullname, bool isPresent)
            {
                students[fullname] = isPresent ? "present" : "absent";
            }
            internal protected string GetStats()
            {
                var count = 0;
                foreach (var student in students.Values)
                {
                    if (student == "present")
                        count++;
                }
                return count * 100.0 / students.Count + " %";
            }
            public virtual void Display()
            {
                Console.WriteLine("    Names\t\t\tAttendance");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Key.PadRight(30, ' ')} {student.Value}");
                }
            }
        }
    }



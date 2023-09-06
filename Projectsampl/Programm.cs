using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projectsampl
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            //List<Student> list = new List<Student>();
            //List<Location> locationList = new List<Location>();
            //var result = student.
            string studentPath = @"D:\BootcampN10-level-1\BootcampN10-level-1\Projectsampl\bin\Debug\net7.0";
            var student = JsonSerializer.Deserialize<List<Student>>
            (File.ReadAllText(studentPath));
            Console.WriteLine(1);
        }

    }
}

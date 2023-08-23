using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace N29_HT2
{
    public class EmployeeService
    {
        public List<Employee> employees = new List<Employee>();

        public async void HireAsync(Employee employee)
        {

            Task.Run(() => { Console.WriteLine("Dear {{Employee}}," +
                "\r\n\r\nThank you for joining the team." +
                " To start your journey we need to first confirm your email address, " +
                "please click on the following link to confirm your email address:\r\n\r\n" +
                "If you received this email mistakenly, please ignore this email.\r\n\r\n" +
                "Thank you".Replace("{{Employee}}", $"{employee.FirstName} {employee.LastName}")); });
            var file = Task.Run(() => { return File.Create($"{employee.FirstName} {employee.LastName}`s employment contract.docs"); });
            var writer = (await Task.WhenAll(file)).Select(file =>
            {
                var message = $"Hurmatli {file.Name}, bu xabarda  shunaqa yozilgan ";
                return file.WriteAsync(Encoding.UTF8.GetBytes(message));
            });


            Task.Run(() => {
                Console.WriteLine("Dear {{Employee}}," +
                    "We are thrilled to welcome you! " +
                    "We are excited to have you on board and look forward to working with you." +
                    "As a new member of our team, we want to make sure you have everything you need to get started." +
                    "Please let us know if you have any questions or need any assistance." +
                    "We wish you all the best in your new role and look forward to your contributions to our team.".Replace("{{Employee}}", $"{employee.FirstName} {employee.LastName}"));
            });

            Task.Run(() =>

                Console.WriteLine("  Task.Run(() => {\r\n           " +
                    "     Console.WriteLine(\"Dear {{Employee}},\" +\r\n " +
                    "                   \"We are thrilled to welcome you! \" +\r\n " +
                    "                   \"We are excited to have you on board and look forward to working with you.\" +\r\n   " +
                    "                 \"As a new member of our team, we want to make sure you have everything you need to get started.\" +\r\n    " +
                    "                \"Please let us know if you have any questions or need any assistance.\" +\r\n  " +
                    "                  \"We wish you all the best in your new role and look forward to your contributions to our team." +
                    "\".Replace(\"{{Employee}}\", $\"{employee.FirstName} {employee.LastName}\"));"
                    .Replace("{{Employee}}", $"{employee.FirstName} {employee.LastName}")));


            








        }
    }
}

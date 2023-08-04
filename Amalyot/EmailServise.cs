using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Amalyot
{
    internal class EmailServise
    {
        public string CredentialsAdress { get; init; }
        public string CredentialsPassword { get; init; }

        public EmailServise()
        {

            
        }

        public void SendEmail(string to, string Username)
        {
            var mail = new MailMessage("Rizo@gmail.com",to);
            mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
            mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz".Replace("{{User}}",Username);

            var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
            smtpClient.Credentials = new NetworkCredential(CredentialsAdress, CredentialsPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }
    }
    

}

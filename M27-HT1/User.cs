using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M27_HT1
{
    public class User
    {
       // private int _id;   // Bu filedLari
        public Guid Id { get; set; }
        public string EmailAdress { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; } 

        public User(string email,string password )
        {
            Id = Guid.NewGuid();
            EmailAdress = email; // qiymat berish
            Password = password;
         
        }

    }
}

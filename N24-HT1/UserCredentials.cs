using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    public class UserCredentials
    {
        public int Id { get; set; }
        public int Password { get; set; }
        public int UserId { get; set; }

        public UserCredentials(int userId,int password,int Id)
        {
            UserId = userId;
            Password = Password;
            this.Id = Id;
        }
      
    }
}

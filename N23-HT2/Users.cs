using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT2
{
    internal class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EamilAdress { get; set; }

        public Users(string FirstName, string LastName, string EmailAdress)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EamilAdress = EmailAdress;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M27_HT1
{
    public class UserService
    {
        private List<User> _users= new List<User>(); // bu kolleksiya olish
        public void Add(string emailAdress,string password)
        {
            if (IsValid(emailAdress))
            {
                _users.Add(new User(emailAdress, password));
            }
            if(!EnsureAdminExists())
            {
                _users[0].IsAdmin= true;
            }
        }
        public bool IsValid(string emailAdress)
        {
            var  eamil = "luboy@gmail.com";
            var pattern = "b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Z|a-z]{2,}";
            Regex regex = new Regex(pattern);
            bool isvalid=regex.IsMatch(emailAdress);
            return isvalid;

        }
        public List<User> GetUsers()
        {
            return _users;
        }
        private bool  EnsureAdminExists()
        {
            var admin=_users.Any(x=>x.IsAdmin); 
            return admin;
        }



    }
}

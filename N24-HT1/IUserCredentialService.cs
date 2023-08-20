using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N24_HT1
{
    public class IUserCredentialService : IUserCredentials
    {
        public interface IUserCredentialsService
        {
            bool AddCredentials(string emailAddress, string password);
        }

        private List<UserCredentials> _userCredentials = new List<UserCredentials>();
        public void Add(int userId, string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool isDigit = false;
            bool hasChar = false;


            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                if (char.IsLower(c))
                {
                    hasLower = true;
                }
                if (char.IsDigit(c))
                {
                    isDigit = true;
                }
                if (char.IsSymbol(c))
                {
                    hasChar = true;
                }
                else
                {
                    throw new Exception();
                }


            }

        }

        private bool CheckStrongPassword(string passowrd)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            // Regex tekshirish
            bool isMatch = Regex.IsMatch(passowrd, pattern);

            return isMatch;
        }


        public UserCredentials? GetByUserId(int userId)
        {
            if (_userCredentials.Any(x => x.Id == userId))
            {
                return _userCredentials.Find(x => x.Id == userId);

            }
            else
            {
                return null;
            }


        }

    }

}


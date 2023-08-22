using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    public class UserCredentialService: IUserCredentialService
    {
        private List<UserCredentials>_userCredentialsList;
        public bool AddCredential(string password,string emailAdress)
        {
            if (emailAdress is null)
            {
                throw new ArgumentNullException(nameof(emailAdress));
            }

            if (!_userCredentialsList.Contains(emailAdress))
            {
                _userCredentialsList[emailAdress] = password;
                return true;


            }
            return false;
        }
    }
}

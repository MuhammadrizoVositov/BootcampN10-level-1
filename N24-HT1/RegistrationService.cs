using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    public class RegistrationService
    {
        private IUserCredentialService _credentialService;
        public RegistrationService(IUserCredentialService credentialService)
        {
            _credentialService = credentialService;
        }
        public bool Register(string firstName,string lastName, string password,string emailAdres ) 
        {
            bool credentalsAdd = _credentialService.Addcredentals[emailAdres];

            if(credentalsAdd)
            {
                var UserCreated = UserService.(firstName, lastName);
                return true;
            }
            return false;
        }
    }
}

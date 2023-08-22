using N24_HT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N24_HT1
{
    public interface  IUserCredentials
    {
        void Add(int userId, int password);
        public string GetByUserId(string userId);


    }


}


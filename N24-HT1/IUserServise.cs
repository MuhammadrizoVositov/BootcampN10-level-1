using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    internal interface IUserServise
    {
        
        List<User> Get(int pageSize, int pageToken);
        List<User> Search(string searchKeyword, int pageSize, int pageToken);
        List<User> Filter(UserFilterModel filterModel);

        List<User> Add(string firstName, string lastName, string eamilAdress);
        List<User>Update(User user);
        List<User>Delete(int id);
    }
}
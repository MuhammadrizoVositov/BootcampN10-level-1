using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }   // bu user ,modelidan foydalanish deyiladi
        public string LastName { get; set; }
        public string EamilAdress { get; set; }
        public bool isDeleted { get; set; }
    }
}

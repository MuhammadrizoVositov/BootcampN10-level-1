using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectsampl
{
    public class Specially
    {
       
        
            public int id { get; set; }
            public string speciality_name { get; set; }
            public Specially(int id, string speciality_name)
            {
                this.id = id;
                this.speciality_name = speciality_name;
            }
          
    }
}

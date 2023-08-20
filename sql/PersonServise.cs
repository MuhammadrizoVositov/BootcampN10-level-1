using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql
{
    public class PersonServise
    {
        private readonly EFCoreContext _context;

        public PersonServise(EFCoreContext context)
        {
            _context = context;
        }

    }
}

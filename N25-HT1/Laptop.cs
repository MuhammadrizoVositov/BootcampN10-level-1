using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    public class Laptop :IProduct
    {
        public string cpuBoard { get; set; }

        public string cpuBrend { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get ; set; }
        public bool IsOrdered { get; set ; }
        public double Price { get; set; }
    }

}

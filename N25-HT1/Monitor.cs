using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    public class Monitor:IProduct
    {
        public int DisplaySize { get; set; }

        public int Refreshrate { get; set; }
        public Guid Id { get; set; }
        public string Name { get ; set ; }
        public string Description { get ; set; }
        public bool IsOrdered { get ; set ; }
        public double Price { get ; set ; }
    }
}

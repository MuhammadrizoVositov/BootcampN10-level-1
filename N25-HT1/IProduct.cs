using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    public interface IProduct
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrdered { get; set; }
        public decimal Price { get; set; }
    }
}



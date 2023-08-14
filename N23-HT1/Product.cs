using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT1
{
    internal class Product
    {

        public string Name { get; set; }    
        public int Stars { get; set; }

        public int inventory { get; set; }

        public Product(string name, int stars, int inventory)
        {
            Name = name;
            Stars = stars;
            inventory = inventory;
        }
    }
   
}

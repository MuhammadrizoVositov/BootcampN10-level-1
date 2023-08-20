using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    public class ProductFilterDataModel
    {
        public  IEnumerable<string>ProducTypes { get; }

        public ProductFilterDataModel(IEnumerable<IProduct>products) 
        {

            ProducTypes = (IEnumerable<string>?)products.Select(product => product.GetType()).Distinct().ToList();
            //if (products.Any())
            //{
            //    products.Select(item => item.GetType().FullName.Distinct());
            //}
            //else
            //{
            //    ProducTypes = IEnumerable.Empty<string>();
            //}
        }
    }
}

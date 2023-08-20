using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    public interface IProductServise
    {
        List<IProduct> Inventory { get; }
        void Add(IProduct product);
        ProductFilterDataModel GetFilterData(ProductFilterDataModel productFilter);

        List<IProduct> Get(ProductFilterDataModel filterModel);

        IProduct Oreder(Guid productId);

        
     

        //public List<IProduct>

    }
}
    


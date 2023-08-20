using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1
{
    public class ProductServise : IProductServise
    {
        public List<IProduct> Inventory => throw new NotImplementedException();

        public void Add(IProduct product)
        {
            Inventory.Add(product);
        }

        public List<IProduct> Get(ProductFilterDataModel filterModel)
        {
            var filter = Inventory.Where(item => filterModel.ProducTypes.Contains(item.GetType().Name)).ToList();
            var products = new List<IProduct>(filter);
            return products;
        }

        public ProductFilterDataModel GetFilterData(ProductFilterDataModel productFilter)
        {
            return new ProductFilterDataModel(Inventory);
        }

        public IProduct Oreder(Guid productId)
        {
            var order = Inventory.Find(item => item.Id == productId);
            order.IsOrdered = true;
            return order;
        }
        public IProduct Return(Guid productId)
        {
            var order = Inventory.Find(item => item.Id == productId);
            order.IsOrdered = false;
            return order;
        }
    }
}
        
        
        
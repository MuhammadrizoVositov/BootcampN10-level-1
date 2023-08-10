using System.Net.Http.Headers;
using HT2a;
List<Product> products = new List<Product>
{
        new Product{Id=Guid.NewGuid(),Name="Coca Cola" },
        new Product{Id=Guid.NewGuid(),Name="Fanta" },
        new Product{Id=Guid.NewGuid(),Name="Pepsi" },
};

var korzinka = new ShoppingCart();
var amount = 0;
foreach (var item  in products)
{
    korzinka.Add( korzinka);
    amount++;
}

class ShoppingCart
{
    public Dictionary<Product,int>products
        =new Dictionary<Product,int>();

    public void Add( Product product,int amount)
    {
   
        
            if(products.ContainsKey(product))
            {
                products[product] = products[product] + amount;

            }
            else
            {
                products.Add(product, amount);
            }
        
    }

    public bool Remove(string ProductName)
    {
        foreach (var prod in products)
        {
            if(prod.Key.Name.Contains(ProductName,StringComparison.OrdinalIgnoreCase) && prod.Value !=0);
            {
                products[prod.Key] = prod.Value-1;
                return true;
            }
        }
        return false;

    }
}



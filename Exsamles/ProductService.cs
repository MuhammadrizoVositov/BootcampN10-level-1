using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exsamles
{
    public class ProductService
    {
        private static ProductService _instance;
        public  List<Product> Products { get; set; }// Singelton pattern deyiladi
        private static ProductService GetInstance()
        {

            if(_instance is null)
            {

                _instance = new ProductService();
            }
            return _instance;
        }
        public void Add(string name,string description) 
        {
            try
            {
                var newProduct = new Product(name, description);
                Products.Add(newProduct);

            }catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Clone(Guid id) 
        {
            var a= Products.Find
                (x => x.Id == id);
            if (a != null)
            {
                Products.Add( new Product(a.Name, a.Description));
            }
            
           
        }
        public void Display(string name,string description)
        {
            foreach (var product in Products) 
            {
                Console.WriteLine($"{product.Name} {product.Description} {product.Id}");
            }
        }
        

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exsamles
{


    public class Product
    {
        private string _name;
        private string _descriptions;
        public Guid Id { get; init; }
        public string Name                                     //Bu name ni null va whitespasega tekshirish deyiladi 
        {
            get => _name;

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new FormatException("Invalid name");
                }
            }

        }
        public string Description
        {
            get => _descriptions;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _descriptions = value;
                }
                else
                {
                    throw new FormatException("Invalid description");
                }
            }
        }
        public Product(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }
        // Bu constructorni copy qilish deyiladi 
        public Product(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
        }

        //internal Product Find(Func<object, bool> value)
        //{
        //    throw new NotImplementedException();
        //}
    }




}

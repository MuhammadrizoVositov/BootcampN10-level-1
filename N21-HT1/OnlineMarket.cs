using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal class OnlineMarket
    {
        private readonly IPaymentProvider _provider;
        private readonly List<Product> _product; // instance yaratish
        private readonly KapitalUzcard uzcards;
        private readonly IDebitCard debitcards;

        public OnlineMarket(IPaymentProvider provider, List<Product> product)// Constructori
        {
            _provider = provider;  // Field saqlash deyiladi
            _product = product;
        }


        public void Add(Product product)
        {
            _product.Add(product);

        }

        public void Buy(string name, int number, IDebitCard myCard, IDebitCard youCard)
        {
            //decimal price;
            //foreach (Product product in _product)
            //{
            //    if(product.Name == name)
            //    {
            //        price = product.Price;
            //    }
            //}

            var amount = _product.Find(a => a.Name == name).Price * number;
            _provider.Transfer(myCard, youCard, amount);
        }

    }
}


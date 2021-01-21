using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Business.Concrete;

namespace ProductManagement.Windows.UI
{
    class LocalStorage : IRepository
    {
        //Vi behöver en lokal lagring av produkter
        private List<Product> products;

        public LocalStorage()
        {
            products = new List<Product>();

            //Vi fejkar lite produkter som start
            products.Add(new Product() { Name = "Kockkniv 30cm", Price = 100 });
            products.Add(new Product() { Name = "Skalkniv 10cm", Price = 25 });
        }
        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}

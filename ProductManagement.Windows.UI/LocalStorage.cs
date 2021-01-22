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
            products.Add(new Product() { Name = "Kockkniv 30cm", Price = 100, Id = 0 });
            products.Add(new Product() { Name = "Skalkniv 10cm", Price = 25, Id = 1 });
            products.Add(new Product() { Name = "Ostkniv 25cm", Price = 40, Id = 2});
        }
        public void Add(Product product)
        {
            products.Add(product);
        }

        public void AddProd(String name, int price)
        {
            products.Add(new Product() { Name = name, Price = price, Id = products.Count} );
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}

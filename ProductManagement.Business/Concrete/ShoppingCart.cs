using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Business.Abstract;
using ProductManagement.Business.Concrete;

namespace ProductManagement.Business.Concrete
{
    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> _products;

        public ShoppingCart()
        {
            _products = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            _products.Add(product as Product); //Explicit!
        }

        public List<IProduct> GetProducts()
        {
            return _products;
        }

        public void RegisterCustomer(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}

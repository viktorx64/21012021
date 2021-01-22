using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Business.Concrete;

namespace ProductManagement.Windows.UI
{
    interface IRepository
    {
        //CRUD
        void Add(Product product);

        void AddProd(String name, int price);

        List<Product> GetProducts();
    }
}

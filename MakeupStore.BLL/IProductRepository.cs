using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProductData();
        Product ProductById(int id);
        Product ProductByName(string name);
        float ProductPrice(int id);
        float ProductPrice(string name);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeupStore.BLL
{
    public class ProductRepository : IProductRepository
    {
        private readonly IList<Product> _productData;

        public ProductRepository(IList<Product> productData)
        {
            _productData = productData;
        }

        public IEnumerable<Product> AllProductData()
        {
            return _productData.ToList();
        }

        public Product ProductById(int id)
        {
            return _productData.First(i => i.Id == id);
        }

        public Product ProductByName(string name)
        {
            return _productData.First(n => n.Name == name);
        }

        public float ProductPrice(int id)
        {
            return ProductById(id).Price;
        }

        public float ProductPrice(string name)
        {
            return ProductByName(name).Price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using MakeupStore.BLL;

namespace MakeupStore.DataAccess
{
    public class ProductDbRepository : IProductRepository
    {
        private readonly MakeupStoreDbContext _dbContext;

        public ProductDbRepository(MakeupStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> AllProductData()
        {
            return _dbContext.Products.ToList();
        }

        public Product ProductById(int id)
        {
            return _dbContext.Products.First(i => i.Id == id);
        }

        public Product ProductByName(string name)
        {
            return _dbContext.Products.First(n => n.Name == name);
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

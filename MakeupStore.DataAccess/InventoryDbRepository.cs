using Microsoft.EntityFrameworkCore;
using MakeupStore.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupStore.DataAccess
{
    public class InventoryDbRepository : IInventoryRepository
    {
        private readonly MakeupStoreDbContext _dbContext;

        public InventoryDbRepository(MakeupStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Inventory> AllInventoryData()
        {
            return _dbContext.Inventory.ToList();
        }

        public void CreateInventoryItem(Inventory inv)
        {
            _dbContext.Inventory.Add(inv);
            _dbContext.SaveChanges();
        }

        public void DeleteInventoryItem(int id)
        {
            _dbContext.Remove(ItemById(id));
            _dbContext.SaveChanges();
        }

        public Inventory ItemById(int id)
        {
            return _dbContext.Inventory.First(i => i.Id == id);
        }

        public float ItemPriceById(int id)
        {
            return _dbContext.Inventory.Where(i => i.Id == id).Sum(p => p.Price);
        }

        public int QuantityById(int id)
        {
            return _dbContext.Inventory.First(i => i.Id == id).Quanity;
        }

        public void UpdateInventory(int id, Inventory inv)
        {
            var oldInv = ItemById(id);
            oldInv.ItemName = inv.ItemName;
            oldInv.Price = inv.Price;
            oldInv.Quanity = inv.Quanity;
            oldInv.Location = inv.Location;
            oldInv.Product = inv.Product;
            _dbContext.SaveChanges();

        }
    }
}

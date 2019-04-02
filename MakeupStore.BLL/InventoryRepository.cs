using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeupStore.BLL
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IList<Inventory> _inventoryData;

        public InventoryRepository(IList<Inventory> inventoryData)
        {
            _inventoryData = inventoryData;
        }

        public IEnumerable<Inventory> AllInventoryData()
        {
            return _inventoryData.ToList();
        }

        public Inventory ItemById(int id)
        {
            return _inventoryData.First(i => i.Id == id);
        }

        public float ItemPriceById(int id)
        {
            return _inventoryData.Where(i => i.Id == id).Sum(p => p.Price);
        }

        public int QuantityById(int id)
        {
            return _inventoryData.First(i => i.Id == id).Quanity;
        }

        public void CreateInventoryItem(Inventory inv)
        {
            if(_inventoryData.Count == 0)
            {
                inv.Id = 1;
            }
            else
            {
                int id = _inventoryData.Max(i => i.Id) + 1;
                inv.Id = id;
            }

            _inventoryData.Add(inv);
        }

        public void UpdateInventory(int id, Inventory inv)
        {
            var oldInv = ItemById(id);
            oldInv.ItemName = inv.ItemName;
            oldInv.Price = inv.Price;
            oldInv.Quanity = inv.Quanity;
            oldInv.Location = inv.Location;
            oldInv.Product = inv.Product;
        }

        public void DeleteInventoryItem(int id)
        {
            _inventoryData.Remove(ItemById(id));
        }

    }
}

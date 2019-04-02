using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public interface IInventoryRepository
    {
        IEnumerable<Inventory> AllInventoryData();
        Inventory ItemById(int id);
        float ItemPriceById(int id);
        int QuantityById(int id);
        void CreateInventoryItem(Inventory inv);
        void UpdateInventory(int id, Inventory inv);
        void DeleteInventoryItem(int id);
    }
}
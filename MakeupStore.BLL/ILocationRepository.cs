using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public interface ILocationRepository
    {
        IEnumerable<Location> AllLocations();
        Location StoreById(int id);
        int ReturnQuantity(int locId, int itemId, Location loc);
        void AddOrderToHistory(int id, Order ord);
        void UpdateQuantity(int locId, int itemId, ICollection<Inventory> inv);
        void UpdateLocation(int id, Location loc);
        void DeleteLocation(int id);
        void AddStore(Location loc);
    }
}

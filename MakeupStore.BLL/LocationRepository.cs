using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeupStore.BLL
{
    public class LocationRepository : ILocationRepository
    {
        private readonly IList<Location> _locationData;
        //private readonly IList<OrderHistory> _storeHistoryData;

        public LocationRepository(IList<Location> locationData)
        {
            _locationData = locationData;
            //_storeHistoryData = storeHistoryData;
        }

        public IEnumerable<Location> AllLocations()
        {
            return _locationData.ToList();
        }

        public Location StoreById(int id)
        {
            return _locationData.First(i => i.Id == id);
        }

        public void AddOrderToHistory(int id, Order ord)
        {
            StoreById(id).StoreHistory.Add(ord);
        }

        public void UpdateQuantity(int locId, int itemId,  ICollection<Inventory> inv)
        {
            StoreById(locId).StoreInventory.First(i => i.Id == itemId).Quanity--;
        }

        public void AddStore(Location loc)
        {
            if (_locationData.Count == 0)
            {
                loc.Id = 1;
            }
            else
            {
                int id = _locationData.Max(i => i.Id) + 1;
                loc.Id = id;
            }
            _locationData.Add(loc);
        }

        public void UpdateLocation(int id, Location loc)
        {
            var oldLoc = StoreById(id);
            oldLoc.LocationName = loc.LocationName;

        }

        public void DeleteLocation(int id)
        {
            _locationData.Remove(StoreById(id));
        }

        public int ReturnQuantity(int locId, int itemId, Location loc)
        {
            var item = StoreById(locId).StoreInventory.First(i => i.Id == itemId);
            return item.Quanity;
        }

    }
}

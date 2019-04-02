using System;
using System.Collections.Generic;
using System.Linq;
using MakeupStore.BLL;

namespace MakeupStore.DataAccess
{
    public class LocationDbRepository : ILocationRepository
    {
        private readonly MakeupStoreDbContext _dbContext;

        public LocationDbRepository(MakeupStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Location> AllLocations()
        {
            return _dbContext.Locations.ToList();
        }

        public Location StoreById(int id)
        {
            return _dbContext.Locations.First(i => i.Id == id);
        }

        public void AddOrderToHistory(int id, Order ord)
        {
            StoreById(id).StoreHistory.Add(ord);
            _dbContext.SaveChanges();
        }

        public void UpdateQuantity(int locId, int itemId, ICollection<Inventory> inv)
        {
            StoreById(locId).StoreInventory.First(i => i.Id == itemId).Quanity--;
            _dbContext.SaveChanges();
        }

        public void AddStore(Location loc)
        {
            _dbContext.Add(loc);
            _dbContext.SaveChanges();
        }

        public void UpdateLocation(int id, Location loc)
        {
            var oldLoc = StoreById(id);
            oldLoc.LocationName = loc.LocationName;
            _dbContext.SaveChanges();
        }

        public void DeleteLocation(int id)
        {
            _dbContext.Remove(StoreById(id));
            _dbContext.SaveChanges();
        }

        public int ReturnQuantity(int locId, int itemId, Location loc)
        {
            var item = StoreById(locId).StoreInventory.First(i => i.Id == itemId);
            return item.Quanity;
        }
    }
}

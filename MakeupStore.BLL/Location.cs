using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }

        public List<Order> StoreHistory { set; get; }
        public ICollection<Inventory> StoreInventory { get; set; }
    }
}

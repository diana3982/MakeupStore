using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public class Inventory
    {
        public int Id { set; get; }
        public string ItemName { set; get; }
        public float Price { set; get; }
        public int Quanity { get; set; }
        public Location Location { get; set; }
        public Product Product { get; set; }

    }
}

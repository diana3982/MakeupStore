using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MakeupStore.App.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string LocationName { get; set; }

        public List<Order> StoreHistory { get; set; }
        public ICollection<Inventory> StoreInventory { get; set; }
    }
}

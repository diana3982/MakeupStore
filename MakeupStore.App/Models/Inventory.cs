using System;
using System.ComponentModel.DataAnnotations;

namespace MakeupStore.App.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string ItemName { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Location Location { get; set; }

        [Required]
        public Product Product { get; set; }


    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace MakeupStore.App.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool IsLtdEd { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public Order Order { get; set; }
    }
}

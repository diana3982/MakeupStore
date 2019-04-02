using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MakeupStore.App.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Location OrderLocation { get; set; }

        [Required]
        public Customer OrderCustomer { get; set; }

        [Display(Name = "Order Time")]
        [DataType(DataType.Date)]
        [Required] // now default value (1/1/1 won't be accepted
        public DateTime OrderTime { get; set; }

        [Required]
        public float Total { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}

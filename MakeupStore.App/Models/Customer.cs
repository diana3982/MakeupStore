using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MakeupStore.App.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public string Email { get; set; }

        //public int DefStore { get; set; }
        public Location DefLocation { get; set; }

        List<Order> OrderHistory { get; set; }
    }
}

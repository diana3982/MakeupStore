using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Location DefStore { get; set; }

        public List<Order> OrderHistory { get; set; }

    }
}

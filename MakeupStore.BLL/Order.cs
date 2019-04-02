using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public class Order
    {
        public Order()
        {

        }
        public int Id { get; set; }
        public Location OrderLocation { get; set; }
        public Customer OrderCustomer { get; set; }
        public DateTime OrderTime { get; set; }
        public float Total { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}

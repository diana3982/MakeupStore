using System;
namespace MakeupStore.BLL
{
    public class OrderItem
    {
        public int Id { get; set; }
        public bool IsLtdEd { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}

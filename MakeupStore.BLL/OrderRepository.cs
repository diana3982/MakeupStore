using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeupStore.BLL
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IList<Order> _orderData;

        public OrderRepository(IList<Order> orderData, IList<Inventory> inventoryData)
        {
            _orderData = orderData;
        }

        public IEnumerable<Order> AllOrderData()
        {
            return _orderData.ToList();
        }

        public Order OrderById(int id)
        {
            return _orderData.First(i => i.Id == id);
        }

        public float OrderTotal()
        {
            return _orderData.Sum(p => p.Total);
        }

        public void CreateOrder(Order ord)
        {
            if (_orderData.Count == 0)
            {
                ord.Id = 1;
            }
            else
            {
                int id = _orderData.Max(i => i.Id) + 1;
                ord.Id = id;
            }

            _orderData.Add(ord);
        }

        public void UpdateOrder(int id, Order ord)
        {
            var oldOrder = OrderById(id);
            oldOrder.OrderLocation = ord.OrderLocation;
            oldOrder.OrderCustomer = ord.OrderCustomer;
            oldOrder.OrderTime = ord.OrderTime;
            oldOrder.Total = ord.Total;

        }

        public void AddToOrderToOrderWithId(int id, OrderItem item)
        {
            OrderById(id).OrderItems.Add(item);
        }

        public void DeleteOrder(int id)
        {
            _orderData.Remove(OrderById(id));
        }
    }
}

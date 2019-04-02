using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeupStore.BLL
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly IList<OrderItem> _orderItemData;

        public OrderItemRepository(IList<OrderItem> orderItemData)
        {
            _orderItemData = orderItemData;
        }

        public IEnumerable<OrderItem> AllOrderItemData()
        {
            return _orderItemData.ToList();
        }

        public OrderItem OrderItemById(int id)
        {
            return _orderItemData.First(i => i.Id == id);
        }

        public bool CheckLtdEdStatusById(int id)
        {
            return _orderItemData.First(i => i.Id == id).IsLtdEd;
        }

        public void AddOrderItem(OrderItem item)
        {
            if ( _orderItemData.Count == 0)
            {
                item.Id = 1;
            }
            else
            {
                int id =  _orderItemData.Max(i => i.Id) + 1;
                item.Id = id;
            }

             _orderItemData.Add(item);
        }

        public void UpdateOrderItem(int id, OrderItem item)
        {
            //int id = item.Id;
            var oldOrderItem = OrderItemById(id);
            oldOrderItem.IsLtdEd = item.IsLtdEd;
            oldOrderItem.Order = item.Order;
            oldOrderItem.Product = item.Product;
            oldOrderItem.Quantity = item.Quantity;

        }

        public void DeleteOrderItem(int id)
        {
            _orderItemData.Remove(OrderItemById(id));
        }
    }
}

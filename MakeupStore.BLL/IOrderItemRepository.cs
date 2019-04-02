using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public interface IOrderItemRepository
    {
        IEnumerable<OrderItem> AllOrderItemData();
        OrderItem OrderItemById(int id);
        bool CheckLtdEdStatusById(int id);
        void AddOrderItem(OrderItem item);
        void UpdateOrderItem(int id, OrderItem item);
        void DeleteOrderItem(int id);
    }
}

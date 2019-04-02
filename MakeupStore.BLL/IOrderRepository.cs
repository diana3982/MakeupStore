using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public interface IOrderRepository
    {
        IEnumerable<Order> AllOrderData();
        Order OrderById(int id);
        float OrderTotal();
        void AddToOrderToOrderWithId(int id, OrderItem item);
        void CreateOrder(Order ord);
        void UpdateOrder(int id, Order ord);
    }
}

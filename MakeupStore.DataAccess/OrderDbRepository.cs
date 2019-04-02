using System;
using System.Collections.Generic;
using System.Linq;
using MakeupStore.BLL;

namespace MakeupStore.DataAccess
{
    public class OrderDbRepository : IOrderRepository
    {
        private readonly MakeupStoreDbContext _dbContext;
        public OrderDbRepository(MakeupStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Order> AllOrderData()
        {
            return _dbContext.Orders.ToList();
        }

        public Order OrderById(int id)
        {
            return _dbContext.Orders.First(i => i.Id == id);
        }

        public float OrderTotal()
        {
            return _dbContext.Orders.Sum(p => p.Total);
        }

        public void CreateOrder(Order ord)
        {
            _dbContext.Add(ord);
            _dbContext.SaveChanges();
        }

        public void UpdateOrder(int id, Order ord)
        {
            var oldOrder = OrderById(id);
            oldOrder.OrderLocation = ord.OrderLocation;
            oldOrder.OrderCustomer = ord.OrderCustomer;
            oldOrder.OrderTime = ord.OrderTime;
            oldOrder.Total = ord.Total;
            _dbContext.SaveChanges();

        }

        public void AddToOrderToOrderWithId(int id, OrderItem item)
        {
            OrderById(id).OrderItems.Add(item);
            _dbContext.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            _dbContext.Orders.Remove(OrderById(id));
            _dbContext.SaveChanges();
        }
    }
}

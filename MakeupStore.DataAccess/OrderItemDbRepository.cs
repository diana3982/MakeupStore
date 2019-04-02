using System;
using System.Collections.Generic;
using System.Linq;
using MakeupStore.BLL;

namespace MakeupStore.DataAccess
{
    public class OrderItemDbRepository : IOrderItemRepository
    {
        private readonly MakeupStoreDbContext _dbContext;

        public OrderItemDbRepository(MakeupStoreDbContext orderItemData)
        {
            _dbContext = orderItemData;
        }

        public IEnumerable<OrderItem> AllOrderItemData()
        {
            return _dbContext.OrderItems.ToList();
        }

        public OrderItem OrderItemById(int id)
        {
            return _dbContext.OrderItems.First(i => i.Id == id);
        }

        public bool CheckLtdEdStatusById(int id)
        {
            return _dbContext.OrderItems.First(i => i.Id == id).IsLtdEd;
        }

        public void AddOrderItem(OrderItem item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();

        }

        public void UpdateOrderItem(int id, OrderItem item)
        {
            //int id = item.Id;
            var oldOrderItem = OrderItemById(id);
            oldOrderItem.IsLtdEd = item.IsLtdEd;
            oldOrderItem.Order = item.Order;
            oldOrderItem.Product = item.Product;
            oldOrderItem.Quantity = item.Quantity;
            _dbContext.SaveChanges();

        }

        public void DeleteOrderItem(int id)
        {
            _dbContext.OrderItems.Remove(OrderItemById(id));
        }
    
    }
}

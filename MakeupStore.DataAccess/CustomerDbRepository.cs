using System;
using System.Collections.Generic;
using System.Linq;
using MakeupStore.BLL;

namespace MakeupStore.DataAccess
{
    public class CustomerDbRepository : ICustomerRepository
    {
        private readonly MakeupStoreDbContext _dbContext;
       
        public CustomerDbRepository(MakeupStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Customer> AllCustomerData()
        {
            return _dbContext.Customers.ToList();
        }

        public Customer CustomerById(int id)
        {
            return _dbContext.Customers.First(i => i.Id == id);
        }

        public Customer CustomerByFullName(string first, string last)
        {
            return _dbContext.Customers.First(f => (f.FirstName == first) && (f.LastName == last));
        }

        public Order OrderById(int id)
        {
            return _dbContext.Orders.First(i => i.Id == id);
        }

        public void AddCustomer(Customer cust)
        {
            _dbContext.Add(cust);
            _dbContext.SaveChanges();
        }

        public void AddOrder(Order ord)
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
            _dbContext.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            _dbContext.Remove(OrderById(id));
            _dbContext.SaveChanges();
        }

        public void FinalizeOrder(int customerId, Order ord)
        {
            CustomerById(customerId).OrderHistory.Add(ord);
            ord.OrderLocation.StoreHistory.Add(ord);
            _dbContext.SaveChanges();
        }
    }
}

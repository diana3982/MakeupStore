using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeupStore.BLL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IList<Customer> _cusomterData;
        private readonly IList<Order> _orderData;

        public CustomerRepository(IList<Customer> customerData, IList<Order> orderData)
        {
            _cusomterData = customerData;
            _orderData = orderData;

        }

        public IEnumerable<Customer> AllCustomerData()
        {
            return _cusomterData.ToList();
        }

        public Customer CustomerById(int id)
        {
            return _cusomterData.First(i => i.Id == id);
        }

        public Customer CustomerByFullName(string first, string last)
        {
           return _cusomterData.First(f => (f.FirstName == first) && (f.LastName == last));
        }

        public Order OrderById(int id)
        {
            return _orderData.First(i => i.Id == id);
        }

        public void AddCustomer(Customer cust)
        {
            if(_cusomterData.Count == 0)
            {
                cust.Id = 1;
            }
            else
            {
                int id = _cusomterData.Max(i => i.Id) + 1;
                cust.Id = id;
            }
            _cusomterData.Add(cust);
        }

        public void AddOrder(Order ord)
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
        }

        public void DeleteOrder(int id)
        {
            _orderData.Remove(OrderById(id));
        }

        public void FinalizeOrder(int customerId, Order ord)
        {
            CustomerById(customerId).OrderHistory.Add(ord);
            ord.OrderLocation.StoreHistory.Add(ord);
        }


    }
}

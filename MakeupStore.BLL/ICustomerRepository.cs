using System;
using System.Collections.Generic;

namespace MakeupStore.BLL
{
    public interface ICustomerRepository
    {

        IEnumerable<Customer> AllCustomerData();
        Customer CustomerById(int id);
        Customer CustomerByFullName(string first, string last);
        Order OrderById(int id);
        void AddCustomer(Customer cust);
        void AddOrder(Order ord);
        void UpdateOrder(int id, Order ord);
        void DeleteOrder(int id);
        void FinalizeOrder(int customerId, Order ord);

    }
}

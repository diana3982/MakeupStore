using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MakeupStore.App.Models;

namespace MakeupStore.App.ViewModels
{
    public class OrderViewModel
    {
        public Order OrderModel { set; get; }
        public Inventory InventoryModel { set; get; }
        public OrderItem OrderItemModel { set; get; }
        public Product ProductModel { set; get; }

        public List<Product> MyProducts { get; set; }
        public IEnumerable<Inventory> IEnumInv { set; get; }
    }
}

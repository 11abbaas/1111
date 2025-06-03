
using StoreAppProject.Helper;
using StoreAppProject.Models;

namespace StoreAppProject.Database
{
    public class StoreAppDatabase
    {
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

        private const string CustomersFile = "customers.json";
        private const string ProductsFile = "products.json";
        private const string OrdersFile = "orders.json";

        public StoreAppDatabase()
        {
            // Fayllardan oxuyuruq və yaddaşa yazırıq
            Customers = JsonHelper.LoadFromJson<Customer>(CustomersFile);
            Products = JsonHelper.LoadFromJson<Product>(ProductsFile);
            Orders = JsonHelper.LoadFromJson<Order>(OrdersFile);
        }

        public void SaveAll()
        {
            // Yaddaşdakı məlumatları JSON fayllara yazırıq
            JsonHelper.SaveToJson(Customers, CustomersFile);
            JsonHelper.SaveToJson(Products, ProductsFile);
            JsonHelper.SaveToJson(Orders, OrdersFile);
        }
    }
}

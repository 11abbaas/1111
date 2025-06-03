using StoreAppProject.Database;
using StoreAppProject.Models;

class Program
{
    static void Main(string[] args)
    {
        // Database obyektini yaradıb yükləyirik
        StoreAppDatabase database = new StoreAppDatabase();

        // Yeni müştəri, məhsul və sifariş əlavə edirik
        database.Customers.Add(new Customer { Id = 1, Name = "Əli" });
        database.Products.Add(new Product { Id = 1, Name = "Qələm", Price = 1.50 });
        database.Orders.Add(new Order { Id = 1, CustomerId = 1, ProductId = 1, Quantity = 3 });

        // Hamısını fayla yazırıq
        database.SaveAll();

        Console.WriteLine("Məlumatlar uğurla yadda saxlanıldı!");
    }
}

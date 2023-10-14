using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var user1 = new User { Username = "user1", Password = "password1" };
        var user2 = new User { Username = "user2", Password = "password2" };
        var product1 = new Product { Name = "Product 1", Price = 10, Category = "Category A", Rating = 4 };
        var product2 = new Product { Name = "Product 2", Price = 15, Category = "Category B", Rating = 3 };
        var store = new Store();
        store.AddUser(user1);
        store.AddUser(user2);
        store.AddProduct(product1);
        store.AddProduct(product2);
        store.PlaceOrder(user1, new List<Product> { product1, product2 }, 2);
        var cheapProducts = store.SearchByPrice(0, 10);
        var categoryAProducts = store.SearchByCategory("Category A");
        var highRatedProducts = store.SearchByRating(4);
        Console.WriteLine("Дешеві товари:");
        foreach (var product in cheapProducts)
        {
            Console.WriteLine(product.Name);
        }

        Console.WriteLine("Товари з категорії A:");
        foreach (var product in categoryAProducts)
        {
            Console.WriteLine(product.Name);
        }

        Console.WriteLine("Високо оцінені товари:");
        foreach (var product in highRatedProducts)
        {
            Console.WriteLine(product.Name);
        }
    }
}
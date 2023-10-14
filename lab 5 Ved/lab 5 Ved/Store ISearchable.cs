using System;
using System.Collections.Generic;
using System.Linq;
class Store : ISearchable
{
    public List<User> Users { get; set; } = new List<User>();
    public List<Product> Products { get; set; } = new List<Product>();
    public List<Order> Orders { get; set; } = new List<Order>();

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void PlaceOrder(User user, List<Product> products, int quantity)
    {
        var order = new Order
        {
            Products = products,
            Quantity = quantity,
            TotalCost = products.Sum(p => p.Price * quantity),
            Status = OrderStatus.Placed
        };

        user.PurchaseHistory.Add(order);
        Orders.Add(order);
    }

    public IEnumerable<Product> SearchByPrice(decimal minPrice, decimal maxPrice)
    {
        return Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice);
    }

    public IEnumerable<Product> SearchByCategory(string category)
    {
        return Products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Product> SearchByRating(int minRating)
    {
        return Products.Where(p => p.Rating >= minRating);
    }
}


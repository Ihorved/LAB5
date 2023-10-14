using System;
using System.Collections.Generic;
using System.Linq;
class Order
{
    public List<Product> Products { get; set; }
    public int Quantity { get; set; }
    public decimal TotalCost { get; set; }
    public OrderStatus Status { get; set; }
}

enum OrderStatus
{
    Placed,
    Shipped,
    Delivered,
    Canceled
}

// Інтерфейс для пошуку товарів
interface ISearchable
{
    IEnumerable<Product> SearchByPrice(decimal minPrice, decimal maxPrice);
    IEnumerable<Product> SearchByCategory(string category);
    IEnumerable<Product> SearchByRating(int minRating);
}

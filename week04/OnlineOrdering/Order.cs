using System;    
using System.Text;
public class Order
{
    private List<Product> _products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = _products.Sum(p => p.GetTotalCost());
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var p in _products)
        {
            label.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
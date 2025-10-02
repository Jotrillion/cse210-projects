using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }
        return total;
    }
    public double CalculateTotalPriceWithShipping()
    {
        double total = CalculateTotalPrice();
        if (_customer.IsInUSA())
        {
            total += 5; // Flat rate for USA
        }
        else
        {
            total += 35; // Flat rate for international
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"- {product.GetName()} (ID: {product.GetId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel(Customer customer)
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }




}
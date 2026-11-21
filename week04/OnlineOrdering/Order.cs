//
// Week 4 Online Ordering Project
// Author: Geoffrey McIntyre
//

using System;
using System.Collections.Generic;

public class Order
{
    // This is a little but unclear to a procedural programmer:
    // An "Order" object consists of a (one) customer and a list of one or more products 
    // being ordered. So it's not a single list of one customer with a list of objects
    // in said list .... So the customer object is paired with the Product list under
    // Order class. The list is a list of product objects.
    public Customer Customer {get;}
    private List<Product> _products = new List<Product>();
    public Order(Customer customer)
    {
        Customer = customer;
    }
    // We add a desired product to the order, called from the main pgm.
    // Remember, the list is called _products
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal CalcOrderCost()
    {
        decimal orderCost = 0m;
        foreach (Product product in _products)
        {
            orderCost = orderCost + product.CalcLineItemCost();
        }
        orderCost = orderCost + GetShippingCost();
        return orderCost;
    }
    public string ShippingLabel()
    {
        string shippingLabel = Customer.CustomerName + "\n";
        shippingLabel = shippingLabel + Customer.Address.Street + "\n";
        shippingLabel = shippingLabel + Customer.Address.City + ", " + Customer.Address.State + "\n"; 
        shippingLabel = shippingLabel + Customer.Address.Country + "\n";
        return shippingLabel;
    }
    public string PackingList()
    {
        string packingList = "";
        foreach (Product product in _products)
        {
            packingList = packingList + product.Quantity + " x ";
            packingList = packingList + product.ProductId;
            packingList = packingList + " " + product.ProductName + "\n";
        }
        return packingList;
    }
    public decimal GetShippingCost()
    {
        if (Customer.Domestic() == true)
            return 5.00m;
        else
            return 35.00m;
    }
}
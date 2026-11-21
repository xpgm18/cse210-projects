//
// Week 4 Online Ordering Project
// Author: Geoffrey McIntyre
//

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create 4 products
        Product p1 = new Product("SP 55", "WaterBug Auto Sump Pump", 187.95m, 56);
        Product p2 = new Product("FD 1002", "Freeze Dryer, Medium, Black", 2995.99m, 16);
        Product p3 = new Product("DCWB 2000", "Deluxe Camp Wash Basin", 57.99m,6);
        Product p4 = new Product("AG 7-26", "Angle Grinder, 7", 96.49m,25);

        //Create 2 customers with addresses
        Customer c1 = new Customer("David Kohler");
        c1.AddAddress("529 Park Ave","Pleasantville", "NY", "USA" );

        Customer c2 = new Customer("Matthew Einstein");
        c2.AddAddress("1054 Monsonato Strasse","Flutstadt", "Steiermark", "AUT" );

        // Add one order for each of the 2 customers
        // The "Order(c1)" ties this new order to the existing "c1" customer.
        // The "public Order(Customer customer)" constructor is thus invoked
        // ("CustomerName = customerName;")
        // NOTE how the product being ordered is tied to the product, and the order
        //      is tied to the customer. Very odd for a procedural programmer.
        Order order1 = new Order(c1);
        Order order2 = new Order(c2);

        order1.AddProduct(p2);
        order1.AddProduct(p4);
        order2.AddProduct(p1);
        order2.AddProduct(p3);

        Console.Clear();

        // Produce the shipping label for the first order
        Console.WriteLine("Shipping Label for the first order:");
        Console.WriteLine($"{order1.ShippingLabel()}");

        //Produce the packing list for the first order
        Console.WriteLine("Packing List");
        Console.WriteLine($"{order1.PackingList()}");
        Console.WriteLine($"The total order cost is {order1.CalcOrderCost()}, which includes a shipping cost of {order1.GetShippingCost()}");

        Console.WriteLine(" ");

        // Produce the shipping label for the second order
        Console.WriteLine("Shipping Label for the second order:");
        Console.WriteLine($"{order2.ShippingLabel()}");

        //Produce the packing list for the second order
        Console.WriteLine("Packing List");
        Console.WriteLine($"{order2.PackingList()}");
        Console.WriteLine($"The total order cost is {order2.CalcOrderCost()}, which includes a shipping cost of {order2.GetShippingCost()}");
    }
}
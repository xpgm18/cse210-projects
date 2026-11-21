//
// Week 4 Online Ordering Project
// Author: Geoffrey McIntyre
//

using System;
using System.Collections.Generic;

public class Product
{
    public string ProductId {get;}
    public string ProductName {get;}
    public decimal ProductPrice {get;}
    public int Quantity {get;}
    public Product(string productId, string productName, decimal productPrice, int quantity)
    {
        ProductId    = productId;
        ProductName  = productName;
        ProductPrice = productPrice;
        Quantity     = quantity;
    }
    public decimal CalcLineItemCost()
    {
        return  ProductPrice * Quantity;
    }
}
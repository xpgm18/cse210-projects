//
// Week 4 Online Ordering Project
// Author: Geoffrey McIntyre
//

using System;
using System.Collections.Generic;

public class Customer
{
    public  string CustomerName {get;}
    // This is interesting: the get; and private set; is in aid of encapsulation:
    // get; alone would make Address = new, etc. not "setable". But the private
    // set makes a method be able to set it. Very interesting.
    public Address Address {get; private set;}
    public Customer(string customerName)
    {
        CustomerName = customerName; 
    }
    public void AddAddress(string street, string city, string state, string country)
    {
        Address = new Address(street, city, state, country);
    }
    public bool Domestic()
    {
        return Address.IsDomestic();
    }
}
//
// Week 4 Online Ordering Project
// Author: Geoffrey McIntyre
//

using System;
using System.Collections.Generic;

public class Address
{
    public string Street {get;}
    public string City {get;}
    public string State {get;}
    public string Country {get;}
    public Address(string street, string city, string state, string country)
    {
        Street  = street;
        City    = city;
        State   = state;
        Country = country;
    }
    public bool IsDomestic()
    {
        if (Country == "USA")
            return true;
        else
            return false;
    }
}
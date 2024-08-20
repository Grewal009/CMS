﻿using System.Reflection.Metadata.Ecma335;

namespace CMS.BL;

public class Customer
{
    public int CustomerId { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public static int InstanceCount { get; set; }

    public string FullName
    {
        get
        {
            string fullName = LastName;
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }

                fullName += FirstName;
            }

            return fullName;
        }
    }

    //Validate customer LastName and EmailAddress
    public bool Validate()
    {
        bool isValid = !string.IsNullOrWhiteSpace(EmailAddress);
        if (string.IsNullOrWhiteSpace(LastName))
        {
            isValid = false;
        }
        return isValid;
    }

    //Retrieve one customer based on customerId
    public Customer Retrieve(int customerId)
    {
        return new Customer();
    }
    
    //Retrieve all customers
    public List<Customer> Retrieve()
    {
        return new List<Customer>();
    }
}
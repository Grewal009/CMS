using System.Reflection.Metadata.Ecma335;

namespace CMS.BL;

public class Customer
{
    public int CustomerId { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public static int InstanceCount { get; set; }

    public List<Address> AddressList { get; set; }

    public Customer():this(0)
    {
        
    }

    public Customer(int customerId)
    {
        CustomerId = customerId;
        AddressList = new List<Address>();
    }

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
    
}
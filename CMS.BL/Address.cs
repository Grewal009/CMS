namespace CMS.BL;

public class Address
{
    public int AddressId { get; private set; }
    public int AddressType { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string State { get; set; }
    public string StreetLine1 { get; set; }
    public string StreetLine2 { get; set; }

    public Address()
    {
    }

    public Address(int addressId)
    {
        AddressId = addressId;
    }
    
    //Validate the address date
    public bool Validate()
    {
        var isValid = !(PostalCode == null);
        return isValid;
    }




}
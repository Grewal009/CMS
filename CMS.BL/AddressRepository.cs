namespace CMS.BL;

public class AddressRepository
{
    //Retrieve one address
    public Address Retrieve(int addressId)
    {
        Address address = new Address(addressId);

        if (addressId == 1)
        {
            address.AddressType = 1;
            address.StreetLine1 = "stor gata";
            address.StreetLine2 = "stor gata";
            address.City = "Oslo";
            address.State = "Oslo";
            address.Country = "Norway";
            address.PostalCode = "47";
        }

        return address;
    }

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
        var addressList = new List<Address>()
        {
            new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "stor gata",
                StreetLine2 = "stor gata",
                City = "Oslo",
                State = "Oslo",
                Country = "Norway",
                PostalCode = "47"
            },
            new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "stor gata",
                StreetLine2 = "stor gata",
                City = "Oslo s",
                State = "Oslo s",
                Country = "Norway",
                PostalCode = "47"
            }
        };
        return addressList;
    }


//Save the current address
    public bool Save()
    {
        return true;
    }



}
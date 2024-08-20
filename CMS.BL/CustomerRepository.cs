namespace CMS.BL;

public class CustomerRepository
{
    private AddressRepository addressRepository { get; set; }


    public CustomerRepository()
    {
        addressRepository = new AddressRepository();
    }

    //Retrieve one customer data
    public Customer Retrieve(int customerId)
    {
        Customer customer = new Customer(customerId);


        if (customerId == 1)
        {
            customer.EmailAddress = "per@gmail.com";
            customer.FirstName = "Per";
            customer.LastName = "Bjørn";
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
        }

        return customer;
    }

    //Save the current customer
    public bool Save()
    {
        return true;
    }
}
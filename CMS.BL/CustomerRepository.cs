namespace CMS.BL;

public class CustomerRepository
{
    
    //Retrieve one customer data
    public Customer Retrieve(int customerId)
    {
        Customer customer = new Customer(customerId);

        if (customerId == 1)
        {
            customer.EmailAddress = "per@gmail.com";
            customer.FirstName = "Per";
            customer.LastName = "Bjørn";
        }

        return customer;
    }
    
    //Save the current customer
    public bool Save()
    {
        return true;
    }


}
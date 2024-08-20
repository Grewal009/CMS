namespace CMS.BL;

public class Order
{
    public DateTimeOffset? OrderDate { get; set; }
    public int OrderId { get; private set; }

    public Order()
    {
        
    }

    public Order(int orderId)
    {
        OrderId = orderId;
    }
    
    //Retrieve one order
    public Order Retrieve(int orderId)
    {
        return new Order();
    }
    
    //Save the current order
    public bool Save()
    {
        return true;
    }
    
    //Validate the order data
    public bool Validate()
    {
        bool isValid = !(OrderDate == null);

        return isValid;
    }




}
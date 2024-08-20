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
    
    //Validate the order data
    public bool Validate()
    {
        bool isValid = !(OrderDate == null);

        return isValid;
    }




}
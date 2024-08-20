namespace CMS.BL;

public class Order
{
    public DateTimeOffset? OrderDate { get; set; }
    public int OrderId { get; private set; }
    public int CustomerId { get; set; }
    public int ShippingAddressId { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    

    public Order():this(0)
    {
        
    }

    public Order(int orderId)
    {
        OrderId = orderId;
        OrderItems = new List<OrderItem>();
    }
    
    //Validate the order data
    public bool Validate()
    {
        bool isValid = !(OrderDate == null);

        return isValid;
    }




}
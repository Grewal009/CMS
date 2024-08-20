namespace CMS.BL;

public class OrderItem
{
    public int OrderItemId { get; private set; }
    public int ProductId { get; set; }
    public decimal? PurchasePrice { get; set; }
    public int Quantity { get; set; }

    public OrderItem()
    {
    }

    public OrderItem(int orderItemId)
    {
        OrderItemId = orderItemId;
    }
    
    //Retrieve one order item
    public OrderItem Retrieve(int orderItemId)
    {
       return new OrderItem();
    }

    //Save the current order item
    public bool Save()
    {
        return true;
    }

    //Validate the order item data
    public bool Validate()
    {
        bool isValid;
        isValid = PurchasePrice != null;
        return isValid;
    }

}
namespace CMS.BL;

public class OrderRepository
{
    //Retrieve order based on order id
    public Order Retrieve(int orderId)
    {
        Order order = new Order(orderId);
        if (orderId == 2)
        {
            order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 2, 2, 22,
                10,
                0, new TimeSpan(7, 0, 0));
            
        }

        return order;
    }

    //Save the current order
    public bool Save()
    {
        return true;
    }
}
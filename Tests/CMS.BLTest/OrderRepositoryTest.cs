using CMS.BL;

namespace CMS.BLTest;


public class OrderRepositoryTest
{
    [Test]
    public void ValidateOrderData()
    {
        //Arrange
        OrderRepository orderRepository = new OrderRepository();
        var expexted = new Order(2)
        {
            OrderDate = new DateTimeOffset(DateTime.Now.Year, 2, 2, 22,
                10,
                0, new TimeSpan(7, 0, 0))
        };

        //Act
        var actual = orderRepository.Retrieve(2);

        //Assert
        Assert.That(expexted.OrderDate,Is.EqualTo(actual.OrderDate));
        Assert.That(expexted.OrderId,Is.EqualTo(actual.OrderId));

    }



}
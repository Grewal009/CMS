using CMS.BL;

namespace CMS.BLTest;

public class CustomerTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FullNameTest()
    {
        //Arrange
        var customer = new Customer();
        customer.FirstNane = "Sam";
        customer.LastName = "Johnsen";

        var expected = customer.LastName + ", " + customer.FirstNane;

        //Act
        var actual = customer.FullName;

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
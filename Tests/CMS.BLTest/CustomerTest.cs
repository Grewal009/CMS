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
        customer.FirstName = "Sam";
        customer.LastName = "Johnsen";

        var expected = customer.LastName + ", " + customer.FirstName;

        //Act
        var actual = customer.FullName;

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void FullNameFirstNameEmpty()
    {
        //Arrange
        Customer customer = new Customer();
        customer.LastName = "Johnson";
        var expected = customer.LastName;

        //Act
        var actual = customer.FullName;

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void FullNameLastNameEmpty()
    {
        //Arrange
        Customer customer = new Customer();
        customer.FirstName = "Sam";
        var expected = customer.FirstName;
        
        //Act
        var actual = customer.FullName;

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void StaticTest()
    {
        //Arrange
        var c1 = new Customer();
        c1.FirstName = "Bob";
        Customer.InstanceCount += 1;
        var c2 = new Customer();
        c2.FirstName = "Per";
        Customer.InstanceCount += 1;
        var c3 = new Customer();
        c3.FirstName = "Pål";
        Customer.InstanceCount += 1;

        var expected = Customer.InstanceCount = 3;
        
        //Act
        var actual = Customer.InstanceCount;

        //Assert
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void ValidateTest()
    {
        //Arrange
        Customer customer = new Customer
        {
            LastName = "Sam",
            EmailAddress = "sam@gmail.com"
        };
        var expected = true;
        
        //Act
        var actual = customer.Validate();

        //Assert
        Assert.That(expected,Is.EqualTo(actual));
    }

    [Test]
    public void ValidateMissingLastName()
    {
        //Arrange
        var customer = new Customer
        {
            EmailAddress = "sam@gmail.com"
        };
        var expected = false;
        
        //Act
        var actual = customer.Validate();

        //Assert
        Assert.That(expected,Is.EqualTo(actual));


    }
}
using CMS.BL;

namespace CMS.BLTest;


public class CustomerRepositoryTest
{
    [Test]
    public void RetrieveValidData()
    {
        //Arrange
        CustomerRepository customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            EmailAddress = "per@gmail.com",
            FirstName = "Per",
            LastName = "Bjørn"
        };

        //Act
        var actual = customerRepository.Retrieve(1);
        
        //Assert
        Assert.That(actual.CustomerId, Is.EqualTo(expected.CustomerId));
        Assert.That(actual.FirstName, Is.EqualTo(expected.FirstName));
        Assert.That(actual.LastName, Is.EqualTo(expected.LastName));
        Assert.That(actual.EmailAddress, Is.EqualTo(expected.EmailAddress));
        
    }
    
}
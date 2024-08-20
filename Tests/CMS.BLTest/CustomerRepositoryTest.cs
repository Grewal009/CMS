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

    [Test]
    public void RetreiveExistingWithAddress()
    {
        //Arrange
        CustomerRepository customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            EmailAddress = "per@gmail.com",
            FirstName = "Per",
            LastName = "Bjørn",
            AddressList = new List<Address>()
            {
                new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "stor gata",
                    StreetLine2 = "stor gata",
                    City = "Oslo",
                    State = "Oslo",
                    Country = "Norway",
                    PostalCode = "47"
                },
                new Address(2)
                {
                    AddressType = 2,
                    StreetLine1 = "stor gata",
                    StreetLine2 = "stor gata",
                    City = "Oslo s",
                    State = "Oslo s",
                    Country = "Norway",
                    PostalCode = "47"
                }
            }
        };
        
        //Act
        var actual = customerRepository.Retrieve(1);

        //Assert
        Assert.That(actual.CustomerId, Is.EqualTo(expected.CustomerId));
        Assert.That(actual.EmailAddress, Is.EqualTo(expected.EmailAddress));
        Assert.That(actual.FirstName, Is.EqualTo(expected.FirstName));
        Assert.That(actual.LastName, Is.EqualTo(expected.LastName));


        for (int i = 0; i < 1; i++)
        {
            Assert.That(actual.AddressList[i].AddressId, Is.EqualTo(expected.AddressList[i].AddressId));
            Assert.That(actual.AddressList[i].AddressType, Is.EqualTo(expected.AddressList[i].AddressType));
            Assert.That(actual.AddressList[i].StreetLine1, Is.EqualTo
                (expected.AddressList[i].StreetLine1));
            Assert.That(actual.AddressList[i].StreetLine2, Is.EqualTo(expected
                .AddressList[i].StreetLine2));
            Assert.That(actual.AddressList[i].City, Is.EqualTo(expected.AddressList[i].City));
            Assert.That(actual.AddressList[i].Country, Is.EqualTo(expected
                .AddressList[i].Country));
            Assert.That(actual.AddressList[i].PostalCode, Is.EqualTo(expected
                .AddressList[i].PostalCode));
        }



    }




}
using CMS.BL;

namespace CMS.BLTest;

public class ProductRepositoryTest
{
    [Test]
    public void RetrieveValidDate()
    {
        //Arrange
        ProductRepository productRepository = new ProductRepository();
        var expected = new Product(2)
        {
            ProductName = "Beans",
            ProductDescription = "250g",
            CurrentPrice = 250
        };
        
        //Act
        var actual = productRepository.Retrieve(2);

        //Assert
        Assert.That(expected.ProductId,Is.EqualTo(actual.ProductId));
        Assert.That(expected.ProductName,Is.EqualTo(actual.ProductName));
        Assert.That(expected.ProductDescription,Is.EqualTo(actual.ProductDescription));
        Assert.That(expected.CurrentPrice,Is.EqualTo(actual.CurrentPrice));


    }
}
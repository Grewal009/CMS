namespace CMS.BL;

public class ProductRepository
{
    //Retrieve one product based on product id
    public Product Retrieve(int productId)
    {
        var product = new Product(productId);
        if (productId == 2)
        {
            product.ProductName = "Beans";
            product.ProductDescription = "250g";
            product.CurrentPrice = 250;
        }

        return product;
    }

    //Save the current product
    public bool Save()
    {
        return true;
    }
}
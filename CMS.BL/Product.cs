namespace CMS.BL;

public class Product
{
    public decimal? CurrentPrice { get; set; }
    public string ProductDescription { get; set; }
    public int ProductId { get; private set; }
    public string ProductName { get; set; }

    public Product()
    {
    }

    public Product(int productId)
    {
        ProductId = productId;
    }

    //Validate the product data
    public bool Validate()
    {
        var isValid = true;
        isValid = !string.IsNullOrWhiteSpace(ProductName);
        if (CurrentPrice == null)
        {
            isValid = false;
        }
        return isValid;
    }
}
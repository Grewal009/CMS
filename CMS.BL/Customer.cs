using System.Reflection.Metadata.Ecma335;

namespace CMS.BL;

public class Customer
{
    public int CustomerId { get; private set; }
    public string FirstNane { get; set; }
    public string LastName { get; set; }
    public string FullName {
        get
        {
            return LastName + ", " + FirstNane;
        }
    }
    
    
}
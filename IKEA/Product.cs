using System.Diagnostics;

namespace IKEA;

public abstract class Product
{
    // FIELDS
    protected string name;
    protected decimal price;
    protected string description;
    
    public decimal GetPrice()
    {
        return price;
    }
    public abstract string GetDescription();
}

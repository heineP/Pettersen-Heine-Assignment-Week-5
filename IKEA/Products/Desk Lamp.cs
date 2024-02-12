using IKEA.Interfaces;

namespace IKEA.Products;

public class DeskLamp:Product, IOffice, IBedroom, IDiscount
{
    // CONSTRUCTOR
    public DeskLamp()
    {
        name = "Desk Lamp";
        price = 700.00m;
        description = "Practical and stylish.";
    }

    public override string GetDescription()
    {
        return $"{description} {Discount()}";
    }

    public string Office()
    {
        return "Would be suitable for your office desk";
    }

    public string Bedroom()
    {
        return "Good for night reading";
    }

    public string Discount()
    {
        return "DISCOUNT: Get 3 for the price of 2!!!";
    }
}
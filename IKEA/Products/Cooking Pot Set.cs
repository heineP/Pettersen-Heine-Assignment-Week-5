using IKEA.Interfaces;

namespace IKEA.Products;

public class CookingPotSet: Product, IDiscount, IKitchen
{
    // CONSTRUCTOR
    public CookingPotSet()
    {
        name = "Cooking Pot Set";
        price = 2499.99m;
        description = "High quality, complete set of cooking pots of different sizes";
    }

    public override string GetDescription()
    {
        return $"{description} {Discount()}";
    }

    public string Discount()
    {
        return "DISCOUNT: 30% OFF for the rest of the month";
    }

    public string Kitchen()
    {
        return "Kitchen stuff";
    }
}
using IKEA.Interfaces;

namespace IKEA.Products;

public class Basket:Product, IDiscount
{
    // CONSTRUCTOR
    public Basket()
    {
        name = "Basket";
        price = 99.00m;
        description = "The cheapest basket!";
    }

    public override string GetDescription()
    {
        return $"{description} {Discount()}";
    }

    public string Discount()
    {
        return "DISCOUNT: get 2 for the price of 1";
    }
}
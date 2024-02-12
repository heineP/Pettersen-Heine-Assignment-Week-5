using IKEA.Interfaces;

namespace IKEA.Products;

public class Carpet:Product, IOffice, ILivingRoom, IBedroom
{
    // CONSTRUCTOR
    public Carpet()
    {
        name = "Carpet";
        price = 1500.00m;
        description = "Fluffy carpet";
    }

    public override string GetDescription()
    {
        return description;
    }
    
    public string Office()
    {
        return "Suitable for offices";
    }
    
    public string LivingRoom()
    {
        return "Suitable for living rooms";
    }
    
    public string Bedroom()
    {
        return " Suitable for bedrooms";
    }
}
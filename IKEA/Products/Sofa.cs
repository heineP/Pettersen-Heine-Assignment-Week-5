using IKEA.Interfaces;

namespace IKEA.Products;

public class Sofa:Product, ILivingRoom
{
    // CONSTRUCTOR
    public Sofa()
    {
        name = "Sofa";
        price = 9000.00m;
        description = "Super comfortable sofa!";
    }

    public override string GetDescription()
    {
        return description;
    }

    public string LivingRoom()
    {
        return "Living room yes";
    }
}
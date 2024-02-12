using IKEA.Interfaces;

namespace IKEA.Products;

public class BunkBed:Product, IAssemblable, IBedroom
{
    // CONSTRUCTOR
    public BunkBed()
    {
        name = "Bunk Bed";
        price = 6500.00m;
        description = "Bunk Bed with 2 sleeping places.";
    }
    
    public override string GetDescription()
    {
        return description;
    }

    public string AssembleGuide()
    {
        return "<Good advice here>";
    }
    public string Bedroom()
    {
        return "Bedroom furniture";
    }
}
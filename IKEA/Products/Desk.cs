using IKEA.Interfaces;

namespace IKEA.Products;

public class Desk:Product, IOffice, IAssemblable
{
    public Desk()
    {
        name = "Desk";
        price = 3500.00m;
        description = "Office desk";
    }

    public override string GetDescription()
    {
        return description;
    }

    public string Office()
    {
        return "Suitable for offices";
    }

    public string AssembleGuide()
    {
        return "<attach legs>";
    }
}
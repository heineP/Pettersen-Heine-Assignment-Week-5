using IKEA.Interfaces;

namespace IKEA.Products;

public class Bookshelf:Product, ILivingRoom, IOffice, IBedroom, IAssemblable
{
    // CONSTRUCTOR
    public Bookshelf()
    {
        name = "Bookshelf";
        price = 4500.00m;
        description = "Lightweight, but fancy bookshelf.";
    }

    public override string GetDescription()
    {
        return description;
    }

    public string LivingRoom()
    {
        return "Suitable for living rooms";
    }

    public string Office()
    {
        return "Suitable for offices";
    }

    public string Bedroom()
    {
        return "Bookshelves everywhere";
    }

    public string AssembleGuide()
    {
        return "<insert assemble guide>";
    }
}
using IKEA.Products;

namespace IKEA;

class Program
{
    static void Main(string[] args)
    {
        DeskLamp lamp1 = new DeskLamp();
        Carpet carpet1 = new Carpet();
        Console.WriteLine(lamp1.GetDescription());
        Console.WriteLine(lamp1.GetPrice());
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(carpet1.GetDescription());
        Console.WriteLine(carpet1.GetPrice());
    }
}

// Design choices -- im not sure if they are best practice/intended for the assignment
// 1. GetPrice() and 'price' as standard inherited methods and attributes, because the method body would be the same in every subclass
// 2. GetDescription() as my abstract method. Some are just return description; and some have added discounts
//      - to get a feel of when to use abstract and when to inherit directly


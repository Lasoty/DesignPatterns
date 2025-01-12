namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Kod klienta działa z fabrykami i produktami tylko przez abstrakcyjne
/// typy: AbstractFactory i AbstractProduct. To pozwala przekazać dowolną
/// podklasę fabryki lub produktu do kodu klienta bez jego łamania.
/// </summary>
class Client
{
    public void Main()
    {
        // Kod klienta może działać z dowolną klasą konkretnej fabryki.
        Console.WriteLine("Klient: Testowanie kodu klienta z pierwszym typem fabryki...");
        ClientMethod(new ConcreteFactory1());
        Console.WriteLine();

        Console.WriteLine("Klient: Testowanie tego samego kodu klienta z drugim typem fabryki...");
        ClientMethod(new ConcreteFactory2());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}
namespace Nadala.DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// Wzorzec projektowy Most
///
/// Cel: Pozwala podzielić dużą klasę lub zestaw blisko powiązanych klas na dwie
/// oddzielne hierarchie — abstrakcję i implementację — które mogą być rozwijane
/// niezależnie od siebie.
/// </summary>
public class BridgePattern
{
    public static void Run()
    {
        Client client = new();

        Abstraction abstraction;
        // Kod klienta powinien być w stanie pracować z dowolną wstępnie skonfigurowaną
        // kombinacją abstrakcji i implementacji.
        abstraction = new Abstraction(new ConcreteImplementationA());
        client.ClientCode(abstraction);

        Console.WriteLine();

        abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
        client.ClientCode(abstraction);
    }
}

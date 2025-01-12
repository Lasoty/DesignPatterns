namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Konkretne Produkty są tworzone przez odpowiadające im Konkretne Fabryki.
/// </summary>
class ConcreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Wynik produktu B1.";
    }

    // Wariant, Produkt B1, może poprawnie działać tylko z
    // wariantem, Produkt A1. Niemniej jednak, akceptuje dowolną instancję
    // AbstractProductA jako argument.
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"Wynik B1 współpracującego z ({result})";
    }
}
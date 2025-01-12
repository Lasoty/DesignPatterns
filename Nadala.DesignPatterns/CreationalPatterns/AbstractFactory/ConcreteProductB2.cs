namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

class ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Wynik produktu B2.";
    }

    // Wariant, Produkt B2, może poprawnie działać tylko z
    // wariantem, Produkt A2. Niemniej jednak, akceptuje dowolną instancję
    // AbstractProductA jako argument.
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"Wynik B2 współpracującego z ({result})";
    }
}
namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Konkretne Produkty są tworzone przez odpowiadające im Konkretne Fabryki.
/// </summary>
class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "Wynik produktu A1.";
    }
}
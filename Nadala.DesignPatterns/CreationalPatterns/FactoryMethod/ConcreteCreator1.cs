namespace Nadala.DesignPatterns.CreationPatterns.FactoryMethod;

/// <summary>
/// Konkretni twórcy nadpisują metodę fabryki, aby zmienić typ tworzonego produktu.
/// </summary>
class ConcreteCreator1 : Creator
{
    // Zwróć uwagę, że sygnatura metody nadal używa abstrakcyjnego typu produktu,
    // mimo że metoda faktycznie zwraca konkretny produkt. W ten sposób Twórca
    // może pozostać niezależny od konkretnych klas produktów.
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}

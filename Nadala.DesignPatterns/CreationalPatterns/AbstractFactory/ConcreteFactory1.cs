namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Konkretne Fabryki produkują rodzinę produktów, które należą do jednego
/// wariantu. Fabryka gwarantuje, że powstałe produkty są kompatybilne.
/// Należy zauważyć, że sygnatury metod Konkretnej Fabryki zwracają abstrakcyjny
/// produkt, podczas gdy wewnątrz metody instancjonowany jest konkretny produkt.
/// </summary>
class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}
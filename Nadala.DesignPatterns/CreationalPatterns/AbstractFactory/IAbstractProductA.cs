namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Każdy odrębny produkt rodziny produktów powinien mieć bazowy interfejs.
/// Wszystkie warianty produktu muszą implementować ten interfejs.
/// </summary>
public interface IAbstractProductA
{
    string UsefulFunctionA();
}
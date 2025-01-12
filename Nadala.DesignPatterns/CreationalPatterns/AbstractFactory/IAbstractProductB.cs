namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Oto bazowy interfejs innego produktu. Wszystkie produkty mogą współdziałać ze sobą,
/// ale poprawne współdziałanie jest możliwe tylko między produktami tego samego konkretnego wariantu.
/// </summary>
public interface IAbstractProductB
{
    // Produkt B może robić swoje...
    string UsefulFunctionB();

    // ...ale może również współpracować z Produktem A.
    //
    // Abstract Factory zapewnia, że wszystkie produkty, które tworzy, są
    // tego samego wariantu i tym samym kompatybilne.
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}
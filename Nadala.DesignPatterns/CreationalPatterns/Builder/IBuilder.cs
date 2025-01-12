namespace Nadala.DesignPatterns.CreationPatterns.Builder;

/// <summary>
/// Interfejs Budowniczego określa metody tworzenia różnych części
/// obiektów Produktu.
/// </summary>
public interface IBuilder
{
    void BuildPartA();

    void BuildPartB();

    void BuildPartC();
}
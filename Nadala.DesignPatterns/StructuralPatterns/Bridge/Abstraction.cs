namespace Nadala.DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// Abstrakcja definiuje interfejs dla części "kontrolnej" dwóch hierarchii klas.
/// Utrzymuje referencję do obiektu z hierarchii Implementacji i deleguje całą
/// rzeczywistą pracę do tego obiektu.
/// </summary>
class Abstraction
{
    protected IImplementation _implementation;

    public Abstraction(IImplementation implementation)
    {
        this._implementation = implementation;
    }

    public virtual string Operation()
    {
        return "Abstract: Podstawowa operacja z:\n" +
               _implementation.OperationImplementation();
    }
}
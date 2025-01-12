namespace Nadala.DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// Implementacja definiuje interfejs dla wszystkich klas implementacji.
/// Nie musi pasować do interfejsu Abstrakcji. W rzeczywistości, oba interfejsy
/// mogą być całkowicie różne. Zazwyczaj interfejs Implementacji dostarcza tylko
/// prymitywne operacje, podczas gdy Abstrakcja definiuje operacje wyższego poziomu
/// oparte na tych prymitywach.
/// </summary>
public interface IImplementation
{
    string OperationImplementation();
}
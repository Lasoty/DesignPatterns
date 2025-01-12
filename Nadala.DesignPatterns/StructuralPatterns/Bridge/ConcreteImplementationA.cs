namespace Nadala.DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// Każda Konkretna Implementacja odpowiada specyficznej platformie i implementuje
/// interfejs Implementacji używając API tej platformy.
/// </summary>
class ConcreteImplementationA : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: Wynik na platformie A.\n";
    }
}
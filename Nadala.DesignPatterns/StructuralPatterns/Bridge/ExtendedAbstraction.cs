namespace Nadala.DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// Możesz rozszerzyć Abstrakcję bez zmiany klas Implementacji.
/// </summary>
class ExtendedAbstraction : Abstraction
{
    public ExtendedAbstraction(IImplementation implementation) : base(implementation)
    {
    }

    public override string Operation()
    {
        return "ExtendedAbstraction: Rozszerzona operacja z:\n" +
               base._implementation.OperationImplementation();
    }
}
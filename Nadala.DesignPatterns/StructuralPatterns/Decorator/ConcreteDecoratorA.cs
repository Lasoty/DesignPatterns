namespace Nadala.DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Konkretne dekoratory wywołują opakowany obiekt i w jakiś sposób zmieniają jego wynik.
/// </summary>
class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component comp) : base(comp)
    {
    }

    /// <summary>
    /// Dekoratory mogą wywoływać implementację operacji rodzica, zamiast bezpośrednio wywoływać opakowany obiekt.
    /// Takie podejście upraszcza rozszerzanie klas dekoratorów.
    /// </summary>
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}
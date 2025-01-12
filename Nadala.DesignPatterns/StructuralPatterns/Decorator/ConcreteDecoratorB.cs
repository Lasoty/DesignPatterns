namespace Nadala.DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Dekoratory mogą wykonywać swoje zachowanie przed lub po wywołaniu opakowanego obiektu.
/// </summary>
class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}
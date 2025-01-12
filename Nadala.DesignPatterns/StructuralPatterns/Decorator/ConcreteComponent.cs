namespace Nadala.DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Konkretne komponenty dostarczają domyślne implementacje operacji.
/// Może istnieć kilka wariantów tych klas.
/// </summary>
class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "ConcreteComponent";
    }
}
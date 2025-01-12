namespace Nadala.DesignPatterns.StructuralPatterns.Composite;

/// <summary>
/// Klasa Leaf reprezentuje końcowe obiekty kompozycji. Liść nie może mieć
/// żadnych dzieci.
/// 
/// Zazwyczaj to obiekty Leaf wykonują rzeczywistą pracę, podczas gdy obiekty
/// Composite tylko delegują ją swoim podkomponentom.
/// </summary>
class Leaf : Component
{
    public override string Operation()
    {
        return "Leaf";
    }

    public override bool IsComposite()
    {
        return false;
    }
}
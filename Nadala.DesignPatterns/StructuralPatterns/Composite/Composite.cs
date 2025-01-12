namespace Nadala.DesignPatterns.StructuralPatterns.Composite;

/// <summary>
/// Klasa Composite reprezentuje złożone komponenty, które mogą mieć dzieci.
/// Zazwyczaj obiekty Composite delegują rzeczywistą pracę swoim dzieciom,
/// a następnie "sumują" wynik.
/// </summary>
class Composite : Component
{
    protected List<Component> _children = new List<Component>();

    public override void Add(Component component)
    {
        this._children.Add(component);
    }

    public override void Remove(Component component)
    {
        this._children.Remove(component);
    }

    /// <summary>
    /// Composite wykonuje swoją główną logikę w szczególny sposób. Przechodzi
    /// rekurencyjnie przez wszystkie swoje dzieci, zbierając i sumując ich
    /// wyniki. Ponieważ dzieci kompozytu przekazują te wywołania swoim dzieciom
    /// i tak dalej, w rezultacie przechodzi przez całe drzewo obiektów.
    /// </summary>
    public override string Operation()
    {
        int i = 0;
        string result = "Branch(";

        foreach (Component component in this._children)
        {
            result += component.Operation();
            if (i != this._children.Count - 1)
            {
                result += "+";
            }
            i++;
        }

        return result + ")";
    }
}
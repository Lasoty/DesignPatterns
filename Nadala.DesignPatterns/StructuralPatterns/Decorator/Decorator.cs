namespace Nadala.DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Klasa bazowa Decorator podąża za tym samym interfejsem co inne komponenty.
/// Głównym celem tej klasy jest zdefiniowanie interfejsu opakowującego dla wszystkich konkretnych dekoratorów.
/// Domyślna implementacja kodu opakowującego może zawierać pole do przechowywania opakowanego komponentu i środki do jego inicjalizacji.
/// </summary>
abstract class Decorator : Component
{
    protected Component _component;

    public Decorator(Component component)
    {
        this._component = component;
    }

    public void SetComponent(Component component)
    {
        this._component = component;
    }

    /// <summary>
    /// Dekorator deleguje całą pracę do opakowanego komponentu.
    /// </summary>
    public override string Operation()
    {
        if (this._component != null)
        {
            return this._component.Operation();
        }
        else
        {
            return string.Empty;
        }
    }
}
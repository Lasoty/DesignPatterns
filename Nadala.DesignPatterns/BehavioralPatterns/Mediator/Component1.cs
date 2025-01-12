namespace Nadala.DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Konkretne Komponenty implementują różne funkcjonalności. Nie zależą od
/// innych komponentów. Nie zależą również od żadnych konkretnych klas mediatorów.
/// </summary>
class Component1 : BaseComponent
{
    public void DoA()
    {
        Console.WriteLine("Komponent 1 wykonuje A.");

        this._mediator.Notify(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Komponent 1 wykonuje B.");

        this._mediator.Notify(this, "B");
    }
}
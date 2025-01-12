namespace Nadala.DesignPatterns.BehavioralPatterns.Mediator;

class Component2 : BaseComponent
{
    public void DoC()
    {
        Console.WriteLine("Komponent 2 wykonuje C.");

        this._mediator.Notify(this, "C");
    }

    public void DoD()
    {
        Console.WriteLine("Komponent 2 wykonuje D.");

        this._mediator.Notify(this, "D");
    }
}
namespace Nadala.DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Konkretni Mediatorzy implementują współpracujące zachowanie poprzez koordynację kilku
/// komponentów.
/// </summary>
class ConcreteMediator : IMediator
{
    private Component1 _component1;

    private Component2 _component2;

    public ConcreteMediator(Component1 component1, Component2 component2)
    {
        this._component1 = component1;
        this._component1.SetMediator(this);
        this._component2 = component2;
        this._component2.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        if (ev == "A")
        {
            Console.WriteLine("Mediator reaguje na A i uruchamia następujące operacje:");
            this._component2.DoC();
        }
        if (ev == "D")
        {
            Console.WriteLine("Mediator reaguje na D i uruchamia następujące operacje:");
            this._component1.DoB();
            this._component2.DoC();
        }
    }
}
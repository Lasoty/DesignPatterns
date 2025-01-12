namespace Nadala.DesignPatterns.BehavioralPatterns.State;

/// <summary>
/// Konkretne stany implementują różne zachowania związane ze stanem Kontekstu.
/// </summary>
class ConcreteStateA : State
{
    public override void Handle1()
    {
        Console.WriteLine("ConcreteStateA obsługuje request1.");
        Console.WriteLine("ConcreteStateA chce zmienić stan kontekstu.");
        this._context.TransitionTo(new ConcreteStateB());
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateA obsługuje request2.");
    }
}
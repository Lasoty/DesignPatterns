namespace Nadala.DesignPatterns.BehavioralPatterns.State;

class ConcreteStateB : State
{
    public override void Handle1()
    {
        Console.Write("ConcreteStateB obsługuje request1.");
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateB obsługuje request2.");
        Console.WriteLine("ConcreteStateB chce zmienić stan kontekstu.");
        this._context.TransitionTo(new ConcreteStateA());
    }
}
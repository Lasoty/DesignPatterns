namespace Nadala.DesignPatterns.BehavioralPatterns.State;

/// <summary>
/// Wzorzec projektowy Stan
///
/// Cel: Pozwala obiektowi zmieniać swoje zachowanie, gdy zmienia się jego wewnętrzny stan.
/// Wygląda to tak, jakby obiekt zmienił swoją klasę.
/// </summary>
public class StatePattern
{
    public static void Run()
    {
        // Kod klienta.
        var context = new Context(new ConcreteStateA());
        context.Request1();
        context.Request2();
    }
}
